﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
//Ab hier für selbst öffnen
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;



namespace Unify_DPO_Tool
{
    using HWND = IntPtr;
    public partial class Form1 : Form
    {
        string hotline;
        string e_teil;
        string fehler;
        string maillink = "mailto:unifydp@de.ibm.com?subject=GER_FRU? - Rückfrage zu Ticket NAxxxxxx KUNDENNAME&bcc=GSI-ProD.IT@unify.com";
        string maillinkEskalation = "mailto:unifydp@de.ibm.com?subject=GER_FRU? - Eskalation bei Ticket NAxxxxxx KUNDENNAME&bcc=GSI-ProD.IT@unify.com&body=Hallo%20Dispo,%0A%0D%0Abei%20Ticket%20NAxxxxxx%20liegt%20eine%20Eskalation%20vor.%0A%0DWir%20bitten%20um%20eine%20schnelle%20Dispostion%20bzw.%20eine%20schnelle%20Anfahrt%20des%20Technikers.";
        string maillinkKomplett="";
        string maillinkEskalationKomplett="";
        static string ordner = Environment.GetEnvironmentVariable("userprofile") + "\\DPOToolSettings";
        public Form1()
        {
            InitializeComponent();
            sparepartvissibilitychange();
            fremdvissibilitychange();
            onsitevissibilitychange();
            //MessageBox.Show("Achtung: Sie nutzen ein Tool in der Beta-Phase!"+Environment.NewLine+"Bei Fragen, Fehlern und Anregungen bitte an Peter Olfen wenden (peter.olfen@atos.net).", "Hinweis",MessageBoxButtons.OK,MessageBoxIcon.Information );
            version.Text = "Version: "+ProductVersion;
            programm_start();
        }

        #region Selbstoeffnen
        // Variablen / Konstanten Deklaration
            #region Deklaration
                private Thread Check_open_closed = null;
                private Thread Check_open_advanced = null;
                public bool check_if_window_open = false;
                public const string bmc_name = "aruser";
                public const string dpof_name = "IMSA:MAIN:TASK:DPO (prd-node.global-intra.net)";
            #endregion
                protected override CreateParams CreateParams
                {
                    get
                    {
                        CreateParams cp = base.CreateParams;
                        cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                        return cp;
                    }
                }

        // Initialisierung einiger Variablen und der Threads für die Fenstersuchfunktion
        void lol_init()
        {

            // Thread 1 - Closed window
            Check_open_closed = new Thread(() =>
            {
                bool window_found = false;

                while (check_if_window_open)
                {

                    foreach (KeyValuePair<IntPtr, string> window in OpenWindowGetter.GetOpenWindows())
                    {

                        IntPtr handle = window.Key;
                        string title = window.Value;
                        if (title.ToLower().Equals(dpof_name.ToLower()))
                        {
                            window_found = true;
                            break;
                        }
                    }
                    if (window_found == true)
                    {
                        this.BeginInvoke((Action)delegate
                        {
                            this.Show();
                            this.Activate();
                        });
                        Thread.Sleep(295000); //55000 <- 1 min / 295.000 <- 5 min
                    }
                    Thread.Sleep(5000);
                    window_found = false;
                }
            });

            // Thread 2 - Advanced KM Search window
            Check_open_advanced = new Thread(() =>
            {

                bool window_found = false;
                while (check_if_window_open)
                {

                    foreach (KeyValuePair<IntPtr, string> window in OpenWindowGetter.GetOpenWindows())
                    {
                        IntPtr handle = window.Key;
                        string title = window.Value;

                        // Console.WriteLine("{0}: {1}", handle, title);

                        if (title.ToLower().Equals(dpof_name.ToLower()))
                        {
                            window_found = true;
                            break;
                        }
                    }
                    if (window_found == true)
                    {
                        this.BeginInvoke((Action)delegate
                        {
                            noticemesenpai();
                        });
                        Thread.Sleep(55000); //55000
                    }
                    Thread.Sleep(5000);
                    window_found = false;


                }

            });

        }
        // Checks if BMC Remedy is even running every 5 seconds (lässt das Programm solange zu bis BMC als Process gestartet ist)
        //public void bmc_running()
        //{
        //    bool bmc = false;
        //    while (bmc == false)
        //    {
        //        Process[] processlist = Process.GetProcesses();
        //        foreach (Process process in processlist)
        //        {
        //            if (!String.IsNullOrEmpty(process.MainWindowTitle))
        //            {
        //                Debug.WriteLine("=====> Process: {0} ID: {1} Window title: {2}", process.ProcessName, process.Id, process.MainWindowTitle);
        //                if (bmc_name.ToLower().Equals(process.ProcessName.ToLower()))
        //                {
        //                    Debug.WriteLine("\n BMC LAEUFT\n");
        //                    bmc = true;
        //                    break;
        //                }
        //            }
        //        }
        //        if (bmc == true)
        //        {
        //            break;
        //        }
        //        Thread.Sleep(5000);
        //    }
        //    check_if_window_open = true;
        //    Check_open_closed.Start();
        //    Check_open_advanced.Start();
        //}
        #endregion


        private void sparepartja_CheckedChanged(object sender, EventArgs e)
        {
            sparepartvissibilitychange();
        } 
        private void fremdremoteja_CheckedChanged(object sender, EventArgs e)
        {
            fremdvissibilitychange();
        }  
        private void onsiteja_CheckedChanged(object sender, EventArgs e)
        {
            onsitevissibilitychange();
        }

        public void sparepartvissibilitychange()
        {
            if(sparepartnein.Checked)
            {
                cb_sparepartchance.Text="0";
                cb_sparepartchance.DropDownStyle = ComboBoxStyle.DropDownList;
                e_teil = "n/a";
            }
            else
            {
                cb_sparepartchance.Text="100";
                cb_sparepartchance.DropDownStyle = ComboBoxStyle.DropDown;
                e_teil = cb_sachnummer.Text;
            }
        }

        public void fremdvissibilitychange()
        {
            if (fremdremotenein.Checked)
            {
                fremdremoteName.ReadOnly = true;
                fremdremotetel.ReadOnly=true;
            }
            else
            {
                fremdremoteName.ReadOnly = false;
                fremdremotetel.ReadOnly=false;
            }
        }
        public void onsitevissibilitychange()
        {
            if (onsitenein.Checked)
            {
                onsitename.ReadOnly = true;
                onsitetel.ReadOnly = true;
                onsitemobil.ReadOnly = true;
            }
            else
            {
                onsitename.ReadOnly = false;
                onsitetel.ReadOnly = false;
                onsitemobil.ReadOnly = false;
            }
        }

        private void  Gruppenauswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktuelleWorkgroup.Text = ((team)cb_gruppenauswahl.SelectedItem).prop_workgroup;
            maillinkKomplett = maillink + "&cc=" + ((team)cb_gruppenauswahl.SelectedItem).prop_email;
            hotline = ((team)cb_gruppenauswahl.SelectedItem).prop_telefon;
            maillinkEskalationKomplett = maillinkEskalation + "&cc=" + ((team)cb_gruppenauswahl.SelectedItem).prop_email + "," + ((team)cb_gruppenauswahl.SelectedItem).prop_modemail + ",michael.wessoleck.atos.net";
        }

        private void texterzeugen_Click(object sender, EventArgs e)
        {
            fehler = "";
            if (e_teil != "n/a")
            {
                e_teil = cb_sachnummer.Text;
            }
            if (requestedalternativefield.Text == "")
            {
                requestedalternativefield.Text = "n/a";
            }
            if (e_teil == "")
            {
                fehler = "Feld \"Sachnummer\" ist leer! Bitte eine Sachnummer angeben.";
            }
            if (issuediscription.Text == "")
            {
                fehler += Environment.NewLine + "Feld \"Issue Discription\" ist leer! Bitte eine Fehler Beschreibung angeben.";
            }

            if (CSIfreitext.Text == "")
            {
                CSIfreitext.Text = "-";
                //fehler += Environment.NewLine + "Feld \"Freitext\" ist leer! Bitte einen Freitext eingeben.";
            }
            // Ausgabe MessageBox mit Fehlern
            if (fehler != "")
            {
                MessageBox.Show(fehler, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string zusatztext = "";
                if (((team)cb_gruppenauswahl.SelectedItem).prop_zusatztext!="")
                { zusatztext = ", " + ((team)cb_gruppenauswahl.SelectedItem).prop_zusatztext; }
                else
                {zusatztext="";}
                //Fremdremote nein und Onsite Nein
                if (fremdremotenein.Checked && onsitenein.Checked)
                {
                    ausgabe.Text = "Spare Part: " + e_teil + Environment.NewLine +
                        "Spare Part Chance: " + cb_sparepartchance.Text + "%" + Environment.NewLine +
                        label11.Text + " " + issuediscription.Text + Environment.NewLine +
                        label10.Text + " " + cb_activitiessofarremote.Text + Environment.NewLine +
                        label12.Text + " " + cb_requestedfromfield.Text + Environment.NewLine +
                        label13.Text + " " + requestedalternativefield.Text + Environment.NewLine +
                        CustomerSpecificInformationgroup.Text + " " + CSIfreitext.Text + ", Unify MSD" + hotline + zusatztext;
                    Clipboard.SetDataObject(ausgabe.Text, false);
                }
                //Fremdremote Ja Onsite Nein
                if (fremdremoteja.Checked && onsitenein.Checked)
                {
                    ausgabe.Text = "Spare Part: " + e_teil + Environment.NewLine +
                        "Spare Part Chance: " + cb_sparepartchance.Text + "%" + Environment.NewLine +
                        label11.Text + " " + issuediscription.Text + Environment.NewLine +
                        label10.Text + " " + cb_activitiessofarremote.Text + Environment.NewLine +
                        label12.Text + " " + cb_requestedfromfield.Text + Environment.NewLine +
                        label13.Text + " " + requestedalternativefield.Text + Environment.NewLine +
                        CustomerSpecificInformationgroup.Text + " " + CSIfreitext.Text + ", Remote Support Contact: " + fremdremoteName.Text + " Tel: " + fremdremotetel.Text + ", Unify MSD" + hotline + zusatztext;
                    Clipboard.SetDataObject(ausgabe.Text, false);
                }
                // Fremdremote Ja Onsite Ja
                if (fremdremoteja.Checked && onsiteja.Checked)
                {
                    ausgabe.Text = "Spare Part: " + e_teil + Environment.NewLine +
                        "Spare Part Chance: " + cb_sparepartchance.Text + "%" + Environment.NewLine +
                        label11.Text + " " + issuediscription.Text + Environment.NewLine +
                        label10.Text + " " + cb_activitiessofarremote.Text + Environment.NewLine +
                        label12.Text + " " + cb_requestedfromfield.Text + Environment.NewLine +
                        label13.Text + " " + requestedalternativefield.Text + Environment.NewLine +
                        CustomerSpecificInformationgroup.Text + " " + CSIfreitext.Text + ", Remote Support Contact: " + fremdremoteName.Text + " Tel: " + fremdremotetel.Text + ", On-Site Contact: " + onsitename.Text + ", Tel: " + onsitetel.Text + " Mobil: " + onsitemobil.Text + ", Unify MSD" + hotline + zusatztext;
                    Clipboard.SetDataObject(ausgabe.Text, false);
                }
                //Fremdreote Nein Onsite Ja
                if (fremdremotenein.Checked && onsiteja.Checked)
                {
                    ausgabe.Text = "Spare Part: " + e_teil + Environment.NewLine +
                        "Spare Part Chance: " + cb_sparepartchance.Text + "%" + Environment.NewLine +
                        label11.Text + " " + issuediscription.Text + Environment.NewLine +
                        label10.Text + " " + cb_activitiessofarremote.Text + Environment.NewLine +
                        label12.Text + " " + cb_requestedfromfield.Text + Environment.NewLine +
                        label13.Text + " " + requestedalternativefield.Text + Environment.NewLine +
                        CustomerSpecificInformationgroup.Text + " " + CSIfreitext.Text + ", On-Site Contact: " + onsitename.Text + ", Tel: " + onsitetel.Text + " Mobil: " + onsitemobil.Text + ", Unify MSD" + hotline + zusatztext;
                    Clipboard.SetDataObject(ausgabe.Text, false);
                }
            }
        }

        private void UnifyDPOWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://mchsrv01.global-intra.net/wiki/index.php5/GO_Work_Instruction:_Erstellung_einer_Dispatch_Order_Field_(DPO_Field)_Grunds%C3%A4tze_und_Regeln");
            }
            catch { }
        }

        private void IBMTechniker_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.ibm.com/contact/employees/de/de/");
            }
            catch { }
        }

        private void IBMDispoMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(maillinkKomplett);
            }
            catch { }
        }

        private void IBMDispoEskalation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(maillinkEskalationKomplett);
            }
            catch { }
        }

        //Bei drücken auf X wird das Fenster minimiert und der Tray Icon der Taskleiste sichtbar.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
                notifyIcon1.BalloonTipText = "Unify DPO Tool";
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();     
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iBMDispoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IBMDispoForm IBMDispo = new IBMDispoForm();
            IBMDispo.Show();
        }

        private void unifyInternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnifyDispoIntern UnifyDispo = new UnifyDispoIntern();
            UnifyDispo.Show();
        }

        private void fRUAbfrageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FruAbfrage IBMFru = new FruAbfrage();
            IBMFru.Show();
        }

        private void fRUBildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRUKarte IBMKarte = new FRUKarte();
            IBMKarte.Show();
        }

        public void OrdnerAbfrage()
        {
            bool existiert = Directory.Exists(ordner);
            if (!existiert)
            {
                Directory.CreateDirectory(ordner);
            }
        }

        public void ConfDateien()
        {
            //Pfade für Configdateien zusammensetzen
            string gruppenconf = ordner + "\\gruppe.conf";
            //Prüfen ob Gruppenconfigurationsdatei vorhanden
            if (File.Exists(gruppenconf))
            {}
            else
            {
                //Wenn nicht vorhanden wird hier geschrieben
                FileStream Pfad = new FileStream(gruppenconf, FileMode.Create, FileAccess.Write);
                StreamWriter schreiben = new StreamWriter(Pfad);
                schreiben.WriteLine("");//Setzen der ersten Gruppe bei Datei Anlegen
                schreiben.Close();
                Pfad.Close();
            }
            confreload();
            
        }

        private void gruppeÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gruppenconf = ordner + "\\gruppe.conf";
            gruppeaendern fenster = new gruppeaendern();
            if (fenster.ShowDialog(this) == DialogResult.Yes)
            {
                MessageBox.Show("Gruppe erfolgreich gespeichert");
                confreload();
            }
            else
            { MessageBox.Show("Gruppe wurde nicht geändert"); }
        }

        private void sachnummernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vorDefTexte_aendern fenster = new vorDefTexte_aendern("sachnummern");
            fenster.Show();
        }

        private void activitiesSoFarInRemoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vorDefTexte_aendern fenster = new vorDefTexte_aendern("remote");
            fenster.Show();
        }

        private void requestedActionFromFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vorDefTexte_aendern fenster = new vorDefTexte_aendern("field");
            fenster.Show();
        }

        private void confreload()
        {
            teamsladen();
            string gruppenconf = ordner + "\\gruppe.conf";

            //Gruppenkonfiguration einlesen und zu weisen
            FileStream Pfad = new FileStream(gruppenconf, FileMode.Open, FileAccess.Read);
            StreamReader lesen = new StreamReader(gruppenconf);
            while (!lesen.EndOfStream)
            {
                cb_gruppenauswahl.SelectedIndex = cb_gruppenauswahl.FindString(lesen.ReadLine());
            }
            lesen.Close();
            Pfad.Close();
            //sachnummern neu laden
            ArrayList liste = new ArrayList();
            cb_activitiessofarremote.Items.Clear();
            liste = sql_aufrufe.SQL_sel_multiple_table_wi_filter("remoteactivity", lb_workgroup.Text, "ALL");
            foreach (a_texte element in liste)
                cb_activitiessofarremote.Items.Add(element);
            liste.Clear();
            cb_requestedfromfield.Items.Clear();
            liste=sql_aufrufe.SQL_sel_multiple_table_wi_filter("reqactionfield", lb_workgroup.Text, "ALL");
            foreach (a_texte element in liste)
                cb_requestedfromfield.Items.Add(element);
            liste.Clear();
        }

        private void konfigurationKomplettNeuEinlesenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confreload();
        }

        //Jonas Klassen
        /// Contains functionality to get all the open windows.
    public static class OpenWindowGetter
    {
        /// <summary>Returns a dictionary that contains the handle and title of all the open windows.</summary>
        /// <returns>A dictionary that contains the handle and title of all the open windows.</returns>
        public static IDictionary<HWND, string> GetOpenWindows()
        {
            HWND shellWindow = GetShellWindow();
            Dictionary<HWND, string> windows = new Dictionary<HWND, string>();

            EnumWindows(delegate(HWND hWnd, int lParam)
            {
                if (hWnd == shellWindow) return true;
                if (!IsWindowVisible(hWnd)) return true;

                int length = GetWindowTextLength(hWnd);
                if (length == 0) return true;

                StringBuilder builder = new StringBuilder(length);
                GetWindowText(hWnd, builder, length + 1);

                windows[hWnd] = builder.ToString();
                return true;

            }, 0);

            return windows;
        }

        delegate bool EnumWindowsProc(HWND hWnd, int lParam);

        [DllImport("USER32.DLL")]
        static extern bool EnumWindows(EnumWindowsProc enumFunc, int lParam);

        [DllImport("USER32.DLL")]
        static extern int GetWindowText(HWND hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("USER32.DLL")]
        static extern int GetWindowTextLength(HWND hWnd);

        [DllImport("USER32.DLL")]
        static extern bool IsWindowVisible(HWND hWnd);

        [DllImport("USER32.DLL")]
        static extern IntPtr GetShellWindow();
    }

    // Tells what to do if the Closed-window is existent
    public void noticemesenpai()
    {
        this.Show();
        this.Activate();
        Thread.Sleep(1000);
    }

    private void überToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ueber fenster = new ueber();
        fenster.Show();
    }

    private void einloggenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        login fenster = new login(this);
        if(fenster.ShowDialog()==DialogResult.OK)
        {
            einloggenToolStripMenuItem.Enabled = false;
            ausloggenToolStripMenuItem.Enabled = true;
            lb_user.Text = fenster.Return1;
            if(fenster.Return2==1)
            {
                teamsVerwaltenToolStripMenuItem.Enabled = true;
                workgroupsToolStripMenuItem.Enabled = true;
            }
            else if(fenster.Return2==2)
            {
                teamsVerwaltenToolStripMenuItem.Enabled = true;
                userToolStripMenuItem.Enabled = true;
                workgroupsToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Fehler bei den Rechten bitte erneut anmelden oder User prüfen!");
            }
        }
        else
        {}
    }

    private void ausloggenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        userToolStripMenuItem.Enabled = false;
        teamsVerwaltenToolStripMenuItem.Enabled = false;
        ausloggenToolStripMenuItem.Enabled = false;
        einloggenToolStripMenuItem.Enabled = true;
        workgroupsToolStripMenuItem.Enabled = false;
        lb_user.Text = "-";
    }

    private void neuToolStripMenuItem_Click(object sender, EventArgs e)
    {
        user fenster = new user("neu");
        fenster.Show();
    }

    private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        user fenster = new user("edit");
        fenster.Show();
    }

    private void neuToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        team_form fenster = new team_form("neu");
        fenster.Show();
    }

    private void bearbeitenToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        team_form fenster = new team_form("edit");
        fenster.Show();
    }

    private void neuToolStripMenuItem2_Click(object sender, EventArgs e)
    {
        workgroup_form fenster = new workgroup_form("neu");
        fenster.Show();
    }

    private void bearbeitenToolStripMenuItem2_Click(object sender, EventArgs e)
    {
        workgroup_form fenster = new workgroup_form("edit");
        fenster.Show();
    }
    private void teamsladen()
    {
        cb_gruppenauswahl.Items.Clear();
        ArrayList teams = new ArrayList();
        teams=sql_aufrufe.SQL_teamsabrufen();
        foreach (team element in teams)
            cb_gruppenauswahl.Items.Add(element);
        teams.Clear();
    }
        public void programm_start()
    {
        teamsladen(); // Laden der Teams aus der Datenbank
        OrdnerAbfrage(); //Prüft ob Konfig Ordner da sind
        ConfDateien(); //Schreibt oder liest config Ordner
        notifyIcon1.ContextMenuStrip = TryIconMenue;
        //Selbst öffnen
        lol_init(); //Prüft ob DPO Fenster im Hintergrund geöffnet wird
        //bmc_running(); auskommentiert weil Programm dann nur mit BMC an läuft
        lb_LDAP_ausgabe.Text = sql_aufrufe.LDAP_telabfragen(Environment.UserName);
    }

    }
}
