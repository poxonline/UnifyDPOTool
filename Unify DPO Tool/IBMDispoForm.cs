using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Unify_DPO_Tool
{
    public partial class IBMDispoForm : Form
    {
        public IBMDispoForm()
        {
            InitializeComponent();
            ArrayList dispo = sql_dispos.select_dispos_extern();
            foreach (dispos element in dispo)
            {
                cb_dispo_extern_auswahl.Items.Add(element);
            }
        }

        private void beenden_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cb_dispo_extern_auswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_ausgabe.Items.Clear();
            lb_ausgabe.Items.Add(((dispos)cb_dispo_extern_auswahl.SelectedItem).prop_name);
            lb_ausgabe.Items.Add("Beschreibung: " + ((dispos)cb_dispo_extern_auswahl.SelectedItem).prop_beschreibung);
            lb_ausgabe.Items.Add("E-Mail:");
            lb_ausgabe.Items.Add(((dispos)cb_dispo_extern_auswahl.SelectedItem).prop_dispomail);
            string name = ((dispos)cb_dispo_extern_auswahl.SelectedItem).prop_name;
            lb_ausgabe.Items.Add("");
            lb_ausgabe.Items.Add("Rufnummern:");
            ArrayList rufnummern = sql_dispos.select_dispo_tel();
            if (rufnummern != null)
            {
                foreach (dispos_tel tel in rufnummern)
                {
                    if (tel.prop_dispo == name)
                    {
                        lb_ausgabe.Items.Add("Beschreibung: " + tel.prop_beschreibung);
                        lb_ausgabe.Items.Add("Rufnummer:");
                        lb_ausgabe.Items.Add(tel.prop_tel);
                    }
                }
            }
            else
                lb_ausgabe.Items.Add("-");
            rufnummern.Clear();
            lb_ausgabe.Items.Add("");
            lb_ausgabe.Items.Add("Ansprechpartner:");
            ArrayList dispoasp = sql_dispos.select_asps_with_dispo((dispos)cb_dispo_extern_auswahl.SelectedItem);
            if (dispoasp != null)
            {
                foreach (asp mensch in dispoasp)
                {
                    lb_ausgabe.Items.Add("Name: " + mensch.prop_name);
                    lb_ausgabe.Items.Add("E-Mail: " + mensch.prop_mail);
                    lb_ausgabe.Items.Add("Rufnummer:");
                    lb_ausgabe.Items.Add(mensch.prop_tel);
                    lb_ausgabe.Items.Add("==============================");
                }
            }
            else
                lb_ausgabe.Items.Add("-");
            dispoasp.Clear();
            GC.Collect();
        }

        private void bt_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(lb_ausgabe.SelectedItem.ToString());
        }

        private void opencircuit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome","https://eu.yourcircuit.com/#/phone?number=+"+lb_ausgabe.SelectedItem.ToString());
        }
    }
}
