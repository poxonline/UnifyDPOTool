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
    public partial class UnifyDispoIntern : Form
    {
        public UnifyDispoIntern()
        {
            InitializeComponent();
            ArrayList dispo = sql_dispos.select_dispos_intern();
            foreach(dispos element in dispo)
            {
                cb_dispo_intern_auswahl.Items.Add(element);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("tel:+4989700720192");
            }
            catch
            {
                MessageBox.Show("Es wurde kein passendes Programm zum Anrufen gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("tel:+4989700723640");
            }
            catch
            {
                MessageBox.Show("Es wurde kein passendes Programm zum Anrufen gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("tel:+4989700720192");
            }
            catch
            {
                MessageBox.Show("Es wurde kein passendes Programm zum Anrufen gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("tel:+4989700723061");
            }
            catch
            {
                MessageBox.Show("Es wurde kein passendes Programm zum Anrufen gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Abhier dann neuer kram
        private void cb_dispo_intern_auswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_ausgabe.Items.Clear();
            lb_ausgabe.Items.Add(((dispos)cb_dispo_intern_auswahl.SelectedItem).prop_name);
            lb_ausgabe.Items.Add("Beschreibung: " + ((dispos)cb_dispo_intern_auswahl.SelectedItem).prop_beschreibung);
            lb_ausgabe.Items.Add("E-Mail:");
            lb_ausgabe.Items.Add(((dispos)cb_dispo_intern_auswahl.SelectedItem).prop_dispomail);
            string name = ((dispos)cb_dispo_intern_auswahl.SelectedItem).prop_name;
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
            ArrayList dispoasp = sql_dispos.select_asps_with_dispo((dispos)cb_dispo_intern_auswahl.SelectedItem);
            if (dispoasp != null)
            {
                foreach(asp mensch in dispoasp)
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

        private void bt_openinCircuit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome", "https://eu.yourcircuit.com/#/phone?number=+" + lb_ausgabe.SelectedItem.ToString());
        }

        private void lb_ausgabe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetDataObject(lb_ausgabe.SelectedItem.ToString());
            }
        }

    }
}
