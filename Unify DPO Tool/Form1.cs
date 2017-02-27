using System;
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
            sparepartnein.Checked=true;
            sparepartvissibilitychange();
            fremdremotenein.Checked = true;
            fremdvissibilitychange();
            onsitenein.Checked = true;
            onsitevissibilitychange();
            //MessageBox.Show("Achtung: Sie nutzen ein Tool in der Beta-Phase!"+Environment.NewLine+"Bei Fragen, Fehlern und Anregungen bitte an Peter Olfen wenden (peter.olfen@unify.com).", "Hinweis",MessageBoxButtons.OK,MessageBoxIcon.Information );
            version.Text = "Version: 0.5 b "+ProductVersion;
            notifyIcon1.ContextMenuStrip = TryIconMenue;
            OrdnerAbfrage();
            ConfDateien();
            //Selbst öffnen
            lol_init();
            //bmc_running(); auskommentiert weil Programm dann nur mit BMC an läuft
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
                sparepartchance.Text="0";
                sparepartchance.DropDownStyle = ComboBoxStyle.DropDownList;
                e_teil = "n/a";
            }
            else
            {
                sparepartchance.Text="100";
                sparepartchance.DropDownStyle = ComboBoxStyle.DropDown;
                e_teil = sachnummer.Text;
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
            if(Gruppenauswahl.Text=="SSD DEU Data Netzpläne+Remotesupport")
            {
                hotline = "Für Netzpläne und Remote Support: Unify MSD 01806020905 Auswahl 2 E-Mail: noc-koeln@unify.com";
                maillinkKomplett = maillink + "&cc=noc-koeln@unify.com";
                maillinkEskalationKomplett=maillinkEskalation+"&cc=noc-koeln@unify.com,michael.wessolleck@atos.net";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU Data";
            }
            else if(Gruppenauswahl.Text=="SSD DEU Data SLA Controlling")
            {
                hotline = "Unify MSD 01806020905 Auswahl 2 E-Mail: noc-koeln@unify.com (Hier bitte bei Ankunft und Abfahrt wegen Zeitkontrolle melden!)";
                maillinkKomplett = maillink + "&cc=noc-koeln@unify.com";
                maillinkEskalationKomplett = maillinkEskalation + "&cc=noc-koeln@unify.com,michael.wessolleck@atos.net";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU Data";
            }
            else if(Gruppenauswahl.Text=="SSD DEU Data Allgemein")
            {
                hotline = "Unify MSD 01806020905 Auswahl 2 E-Mail: noc-koeln@unify.com";
                maillinkKomplett = maillink + "&cc=noc-koeln@unify.com";
                maillinkEskalationKomplett = maillinkEskalation + "&cc=noc-koeln@unify.com,michael.wessolleck@atos.net";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU Data";
            }
            else if(Gruppenauswahl.Text=="SSD DEU Voice")
            {
                hotline = "Unify MSD 01806020905 Auswahl 3 E-Mail: noc-voise.svs@unify.com";
                maillinkKomplett = maillink + "&cc=noc-voise.svs@unify.com";
                maillinkEskalationKomplett = maillinkEskalation + "&cc=noc-voise.svs@unify.com,michael.wessolleck@atos.net";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU Voice";
            }
            else if(Gruppenauswahl.Text=="SSD DEU UC")
            {
                hotline = "Unify MSD 01806020905 Auswahl 4 E-Mail: gsi.sd-h8k@unify.com";
                maillinkKomplett = maillink + "&cc=gsi.sd-h8k@unify.com";
                maillinkEskalationKomplett = maillinkEskalation + "&cc=gsi.sd-h8k@unify.com,michael.wessolleck@atos.net";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU UC";
            }
            else if(Gruppenauswahl.Text=="SSD DEU Security")
            {
                hotline = "Unify MSD 01806020905 Auswahl 5 E-Mail: security.hotline@unify.com";
                maillinkKomplett = maillink + "&cc=security.hotline@unify.com";
                maillinkEskalationKomplett = maillinkEskalation + "&cc=security.hotline@unify.com,michael.wessolleck@atos.net";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU Security";
            }
            else if (Gruppenauswahl.Text == "SSD DEU BA")
            {
                hotline = "Unify MSD 08007373622 E-Mail: ba-servicedesk@unify.com";
                maillinkKomplett = maillink + "&cc=ba-servicedesk@unify.com";
                maillinkEskalationKomplett = maillinkEskalation + "&cc=ba-servicedesk@unify.com.com,michael.wessolleck@atos.net";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU BA";
            }
        }

        private void texterzeugen_Click(object sender, EventArgs e)
        {
            fehler = "";
            if (e_teil != "n/a")
            {
                e_teil = sachnummer.Text;
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
                //Fremdremote nein und Onsite Nein
                if (fremdremotenein.Checked && onsitenein.Checked)
                {
                    ausgabe.Text = "Spare Part: " + e_teil + Environment.NewLine +
                        "Spare Part Chance: " + sparepartchance.Text + "%" + Environment.NewLine +
                        label11.Text + " " + issuediscription.Text + Environment.NewLine +
                        label10.Text + " " + activitiessofarremote.Text + Environment.NewLine +
                        label12.Text + " " + requestedfromfield.Text + Environment.NewLine +
                        label13.Text + " " + requestedalternativefield.Text + Environment.NewLine +
                        CustomerSpecificInformationgroup.Text + " " + CSIfreitext.Text + ", " + hotline;
                    Clipboard.SetDataObject(ausgabe.Text, false);
                }
                //Fremdremote Ja Onsite Nein
                if (fremdremoteja.Checked && onsitenein.Checked)
                {
                    ausgabe.Text = "Spare Part: " + e_teil + Environment.NewLine +
                        "Spare Part Chance: " + sparepartchance.Text + "%" + Environment.NewLine +
                        label11.Text + " " + issuediscription.Text + Environment.NewLine +
                        label10.Text + " " + activitiessofarremote.Text + Environment.NewLine +
                        label12.Text + " " + requestedfromfield.Text + Environment.NewLine +
                        label13.Text + " " + requestedalternativefield.Text + Environment.NewLine +
                        CustomerSpecificInformationgroup.Text + " " + CSIfreitext.Text + ", Remote Support Contact: " + fremdremoteName.Text + " Tel: " + fremdremotetel.Text + ", " + hotline;
                    Clipboard.SetDataObject(ausgabe.Text, false);
                }
                // Fremdremote Ja Onsite Ja
                if (fremdremoteja.Checked && onsiteja.Checked)
                {
                    ausgabe.Text = "Spare Part: " + e_teil + Environment.NewLine +
                        "Spare Part Chance: " + sparepartchance.Text + "%" + Environment.NewLine +
                        label11.Text + " " + issuediscription.Text + Environment.NewLine +
                        label10.Text + " " + activitiessofarremote.Text + Environment.NewLine +
                        label12.Text + " " + requestedfromfield.Text + Environment.NewLine +
                        label13.Text + " " + requestedalternativefield.Text + Environment.NewLine +
                        CustomerSpecificInformationgroup.Text + " " + CSIfreitext.Text + ", Remote Support Contact: " + fremdremoteName.Text + " Tel: " + fremdremotetel.Text + ", On-Site Contact: " + onsitename.Text + ", Tel: " + onsitetel.Text + " Mobil: " + onsitemobil.Text + ", " + hotline;
                    Clipboard.SetDataObject(ausgabe.Text, false);
                }
                //Fremdreote Nein Onsite Ja
                if (fremdremotenein.Checked && onsiteja.Checked)
                {
                    ausgabe.Text = "Spare Part: " + e_teil + Environment.NewLine +
                        "Spare Part Chance: " + sparepartchance.Text + "%" + Environment.NewLine +
                        label11.Text + " " + issuediscription.Text + Environment.NewLine +
                        label10.Text + " " + activitiessofarremote.Text + Environment.NewLine +
                        label12.Text + " " + requestedfromfield.Text + Environment.NewLine +
                        label13.Text + " " + requestedalternativefield.Text + Environment.NewLine +
                        CustomerSpecificInformationgroup.Text + " " + CSIfreitext.Text + ", On-Site Contact: " + onsitename.Text + ", Tel: " + onsitetel.Text + " Mobil: " + onsitemobil.Text + ", " + hotline;
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
            string sachconf = ordner+"\\sachnummern.conf";
            string actionconf = ordner+"\\actionremote.conf";
            string requestedconf = ordner+"\\requestedfromfield.conf";
            //Prüfen ob Gruppenconfigurationsdatei vorhanden
            if (File.Exists(gruppenconf))
            {
                //Wenn vorhanden wird hier gelesen
                FileStream Pfad = new FileStream(gruppenconf, FileMode.Open, FileAccess.Read);
                StreamReader lesen = new StreamReader(gruppenconf);
                while (!lesen.EndOfStream)
                {
                    Gruppenauswahl.Text = lesen.ReadLine();
                }
                lesen.Close();
                Pfad.Close();
            }
            else
            {
                //Wenn nicht vorhanden wird hier geschrieben
                FileStream Pfad = new FileStream(gruppenconf, FileMode.Create, FileAccess.Write);
                StreamWriter schreiben = new StreamWriter(Pfad);
                schreiben.WriteLine("SSD DEU Data Allgemein");//Setzen der ersten Gruppe bei Datei Anlegen
                schreiben.Close();
                Pfad.Close();
            }

            if (File.Exists(sachconf))
            {
                ArrayList gelesen=new ArrayList();
                //Wenn vorhanden wird hier gelesen
                FileStream Pfad = new FileStream(sachconf, FileMode.Open, FileAccess.Read);
                StreamReader lesen = new StreamReader(sachconf);
                while (!lesen.EndOfStream)
                {
                     gelesen.Add(lesen.ReadLine());
                }
                lesen.Close();
                Pfad.Close();
                foreach (string i in gelesen)
                {
                    sachnummer.Items.Add(i);
                }
            }
            else
            {
                FileStream Pfad = new FileStream(sachconf, FileMode.Create, FileAccess.Write);
                StreamWriter schreiben = new StreamWriter(Pfad);
                schreiben.WriteLine("n/a");
                schreiben.WriteLine("DE:DEUBA_JUI_SSG-5-SH");
                schreiben.WriteLine("DE:DEUBA_JUI_SRX100B");
                schreiben.WriteLine("DE:DEUBA_JUI_NS-5GT-005");
                schreiben.WriteLine("CIO:AIR-LAP1142N-E-K9");
                schreiben.WriteLine("EXN:15107");
                schreiben.Close();
                Pfad.Close();
            }
            if (File.Exists(actionconf))
            {
                ArrayList gelesen = new ArrayList();
                //Wenn vorhanden wird hier gelesen
                FileStream Pfad = new FileStream(actionconf, FileMode.Open, FileAccess.Read);
                StreamReader lesen = new StreamReader(actionconf);
                while (!lesen.EndOfStream)
                {
                    gelesen.Add(lesen.ReadLine());
                }
                lesen.Close();
                Pfad.Close();
                foreach (string i in gelesen)
                {
                    activitiessofarremote.Items.Add(i);
                }
            }
            else
            {
                FileStream Pfad = new FileStream(actionconf, FileMode.Create, FileAccess.Write);
                StreamWriter schreiben = new StreamWriter(Pfad);
                schreiben.WriteLine("Kein Remote erlaubt.");
                schreiben.WriteLine("Kein Remote möglich.");
                schreiben.WriteLine("Prüfung des Endgerätes, es wurde ein Hardware defekt festgestellt.");
                schreiben.Close();
            }
            if (File.Exists(requestedconf))
            {
                ArrayList gelesen = new ArrayList();
                //Wenn vorhanden wird hier gelesen
                FileStream Pfad = new FileStream(requestedconf, FileMode.Open, FileAccess.Read);
                StreamReader lesen = new StreamReader(requestedconf);
                while (!lesen.EndOfStream)
                {
                    gelesen.Add(lesen.ReadLine());
                }
                lesen.Close();
                Pfad.Close();
                foreach (string i in gelesen)
                {
                    requestedfromfield.Items.Add(i);
                }
            }
            else
            {
                FileStream Pfad = new FileStream(requestedconf, FileMode.Create, FileAccess.Write);
                StreamWriter schreiben = new StreamWriter(Pfad);
                schreiben.WriteLine("Tauschen des OpenStage Endgerätes.");
                schreiben.WriteLine("Tauschen der Juniper und ggf. Konfiguration dieser (Konsolenkabel benötigt)");
                schreiben.WriteLine("Tauschen des Netzteils");
                schreiben.WriteLine("Tauschen der Festplatte");
                schreiben.WriteLine("Tauschen des AccessPoints AP_XXXX am Switch XXXXXXX");
                schreiben.WriteLine("Tauschen des Switches, inklusive einspielen der BackUp Konfiguration (Konsolenkabel benötigt)");
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
                FileStream Pfad = new FileStream(gruppenconf, FileMode.Open, FileAccess.Read);
                StreamReader lesen = new StreamReader(gruppenconf);
                while (!lesen.EndOfStream)
                {
                    Gruppenauswahl.Text = lesen.ReadLine();
                }
                lesen.Close();
                Pfad.Close();
            }
            else
            { MessageBox.Show("Gruppe wurde nicht gespeichert"); }
        }

        private void sachnummernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sachconf = ordner + "\\sachnummern.conf";
            vorDefTexte_aendern fenster = new vorDefTexte_aendern(sachconf);
            if (fenster.ShowDialog(this) == DialogResult.Yes)
            {
                MessageBox.Show("Sachnummern erfolgreich gespeichert");
                sachnummer.Items.Clear();
                FileStream Pfad = new FileStream(sachconf, FileMode.Open, FileAccess.Read);
                StreamReader lesen = new StreamReader(sachconf);
                while (!lesen.EndOfStream)
                {
                    sachnummer.Items.Add(lesen.ReadLine());
                }
                lesen.Close();
                Pfad.Close();
            }
            else
            { MessageBox.Show("Sachnummern wurden nicht gespeichert"); }
        }

        private void activitiesSoFarInRemoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string actionconf = ordner + "\\actionremote.conf";
            vorDefTexte_aendern fenster = new vorDefTexte_aendern(actionconf);
            if (fenster.ShowDialog(this) == DialogResult.Yes)
            {
                MessageBox.Show("Action so far in Remote erfolgreich gespeichert");
                activitiessofarremote.Items.Clear();
                FileStream Pfad = new FileStream(actionconf, FileMode.Open, FileAccess.Read);
                StreamReader lesen = new StreamReader(actionconf);
                while (!lesen.EndOfStream)
                {
                    activitiessofarremote.Items.Add(lesen.ReadLine());
                }
                lesen.Close();
                Pfad.Close();
            }
            else
            { MessageBox.Show("Action so far in Remote wurde nicht gespeichert"); }
        }

        private void requestedActionFromFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string requestedconf = ordner + "\\requestedfromfield.conf";
            vorDefTexte_aendern fenster = new vorDefTexte_aendern(requestedconf);
            if (fenster.ShowDialog(this) == DialogResult.Yes)
            {
                MessageBox.Show("Requested Action from Field erfolgreich gespeichert");
                requestedfromfield.Items.Clear();
                FileStream Pfad = new FileStream(requestedconf, FileMode.Open, FileAccess.Read);
                StreamReader lesen = new StreamReader(requestedconf);
                while (!lesen.EndOfStream)
                {
                    requestedfromfield.Items.Add(lesen.ReadLine());
                }
                lesen.Close();
                Pfad.Close();
            }
            else
            { MessageBox.Show("Requested Action from Field wurde nicht gespeichert"); }
        }

        private void confreload()
        {
            //Alle configs neu ein lesen
            string gruppenconf = ordner + "\\gruppe.conf";
            string sachconf = ordner + "\\sachnummern.conf";
            string actionconf = ordner + "\\actionremote.conf";
            string requestedconf = ordner + "\\requestedfromfield.conf";

            //Gruppenkonfiguration
            FileStream Pfad = new FileStream(gruppenconf, FileMode.Open, FileAccess.Read);
            StreamReader lesen = new StreamReader(gruppenconf);
            while (!lesen.EndOfStream)
            {
                Gruppenauswahl.Text = lesen.ReadLine();
            }
            lesen.Close();
            Pfad.Close();

            //Sachnummern
            sachnummer.Items.Clear();
            ArrayList gelesen2 = new ArrayList();
            FileStream Pfad2 = new FileStream(sachconf, FileMode.Open, FileAccess.Read);
            StreamReader lesen2 = new StreamReader(sachconf);
            while (!lesen2.EndOfStream)
            {
                gelesen2.Add(lesen2.ReadLine());
            }
            lesen2.Close();
            Pfad2.Close();
            foreach (string i in gelesen2)
            {
                sachnummer.Items.Add(i);
            }

            //Bisher durchgeführte Remoteaktionen
            activitiessofarremote.Items.Clear();
            ArrayList gelesen3 = new ArrayList();
            FileStream Pfad3 = new FileStream(actionconf, FileMode.Open, FileAccess.Read);
            StreamReader lesen3 = new StreamReader(actionconf);
            while (!lesen3.EndOfStream)
            {
                gelesen3.Add(lesen3.ReadLine());
            }
            lesen3.Close();
            Pfad3.Close();
            foreach (string i in gelesen3)
            {
                activitiessofarremote.Items.Add(i);
            }

            //Erwartete Technikeraktionen
            requestedfromfield.Items.Clear();
            ArrayList gelesen4 = new ArrayList();
            FileStream Pfad4 = new FileStream(requestedconf, FileMode.Open, FileAccess.Read);
            StreamReader lesen4 = new StreamReader(requestedconf);
            while (!lesen4.EndOfStream)
            {
                gelesen4.Add(lesen4.ReadLine());
            }
            lesen4.Close();
            Pfad4.Close();
            foreach (string i in gelesen4)
            {
                requestedfromfield.Items.Add(i);
            }
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

    }
}
