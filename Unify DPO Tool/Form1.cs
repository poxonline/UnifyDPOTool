﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unify_DPO_Tool
{
    public partial class Form1 : Form
    {
        string hotline;
        string e_teil;
        string fehler;
        string maillink = "mailto:unifydp@de.ibm.com?subject=GER_FRU? - Rückfrage zu Ticket NAxxxxxx KUNDENNAME&bcc=GSI-ProD.IT@unify.com";
        string maillinkEskalation = "mailto:unifydp@de.ibm.com?subject=GER_FRU? - Eskalation bei Ticket NAxxxxxx KUNDENNAME&bcc=GSI-ProD.IT@unify.com&body=Hallo%20Dispo,%0A%0D%0Abei%20Ticket%20NAxxxxxx%20liegt%20eine%20Eskalation%20vor.%0A%0DWir%20bitten%20um%20eine%20schnelle%20Dispostion%20bzw.%20eine%20schnelle%20Anfahrt%20des%20Technikers.";
        string maillinkKomplett="";
        string maillinkEskalationKomplett="";
        //Test
        public Form1()
        {
            InitializeComponent();
            sparepartnein.Checked=true;
            sparepartvissibilitychange();
            fremdremotenein.Checked = true;
            fremdvissibilitychange();
            onsitenein.Checked = true;
            onsitevissibilitychange();
            MessageBox.Show("Achtung: Sie nutzen ein Tool in der Beta-Phase!"+Environment.NewLine+"Bei Fragen, Fehlern und Anregungen bitte an Peter Olfen wenden (peter.olfen@unify.com).", "Hinweis",MessageBoxButtons.OK,MessageBoxIcon.Information );
            version.Text = "Version: 0.2.1.1 b";
            Gruppenauswahl.Text = "SSD DEU Data SLA Controlling";
            notifyIcon1.ContextMenuStrip = TryIconMenue;
        }
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
                maillinkEskalationKomplett=maillinkEskalation+"&cc=noc-koeln@unify.com,michael.wessolleck@unify.com";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU Data";
            }
            else if(Gruppenauswahl.Text=="SSD DEU Data SLA Controlling")
            {
                hotline = "Unify MSD 01806020905 Auswahl 2 E-Mail: noc-koeln@unify.com (Hier bitte bei Ankunft und Abfahrt wegen Zeitkontrolle melden!)";
                maillinkKomplett = maillink + "&cc=noc-koeln@unify.com";
                maillinkEskalationKomplett=maillinkEskalation+"&cc=noc-koeln@unify.com,michael.wessolleck@unify.com";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU Data";
            }
            else if(Gruppenauswahl.Text=="SSD DEU Data Allgemein")
            {
                hotline = "Unify MSD 01806020905 Auswahl 2 E-Mail: noc-koeln@unify.com";
                maillinkKomplett = maillink + "&cc=noc-koeln@unify.com";
                maillinkEskalationKomplett=maillinkEskalation+"&cc=noc-koeln@unify.com,michael.wessolleck@unify.com";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU Data";
            }
            else if(Gruppenauswahl.Text=="SSD DEU Voice")
            {
                hotline = "Unify MSD 01806020905 Auswahl 3 E-Mail: noc-voise.svs@unify.com";
                maillinkKomplett = maillink + "&cc=noc-voise.svs@unify.com";
                maillinkEskalationKomplett=maillinkEskalation+"&cc=noc-voise.svs@unify.com,michael.wessolleck@unify.com";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU Voice";
            }
            else if(Gruppenauswahl.Text=="SSD DEU UC")
            {
                hotline = "Unify MSD 01806020905 Auswahl 4 E-Mail: gsi.sd-h8k@unify.com";
                maillinkKomplett = maillink + "&cc=gsi.sd-h8k@unify.com";
                maillinkEskalationKomplett=maillinkEskalation+"&cc=gsi.sd-h8k@unify.com,michael.wessolleck@unify.com";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU UC";
            }
            else if(Gruppenauswahl.Text=="SSD DEU Security")
            {
                hotline = "Unify MSD 01806020905 Auswahl 5 E-Mail: security.hotline@unify.com";
                maillinkKomplett = maillink + "&cc=security.hotline@unify.com";
                maillinkEskalationKomplett=maillinkEskalation+"&cc=security.hotline@unify.com,michael.wessolleck@unify.com";
                aktuelleWorkgroup.Text = "Aktuelle Workgroup: SSD DEU Security";
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
    }
}
