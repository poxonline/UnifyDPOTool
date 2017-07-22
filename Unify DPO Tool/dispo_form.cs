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
    public partial class dispo_form : Form
    {
        public dispo_form()
        {
            InitializeComponent();
            aktualisieren();
        }
        public void aktualisieren()
        {
            cb_dispo_auswahl.Items.Clear();
            tb_id.Text = "";
            tb_name.Text = "";
            tb_Beschreibung.Text = "";
            tb_email.Text = "";
            cb_FRU.Checked = false;
            cb_email_normal.Checked = false;
            cb_email_eskalation.Checked = false;
            cb_partner.Checked = false;
            ArrayList dispoliste = new ArrayList();
            dispoliste = sql_dispos.select_dispos();
            foreach(dispos element in dispoliste)
            {
                cb_dispo_auswahl.Items.Add(element);
            }
        }

        private void bt_anlegen_Click(object sender, EventArgs e)
        {
            sql_dispos.add_dispo(new dispos(0, tb_name.Text, tb_email.Text, cb_FRU.Checked, cb_email_normal.Checked, cb_email_eskalation.Checked, tb_Beschreibung.Text, cb_partner.Checked));
            aktualisieren();
        }

        private void cb_dispo_auswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_id.Text =Convert.ToString(((dispos)cb_dispo_auswahl.SelectedItem).prop_id);
            tb_name.Text = ((dispos)cb_dispo_auswahl.SelectedItem).prop_name;
            tb_Beschreibung.Text = ((dispos)cb_dispo_auswahl.SelectedItem).prop_beschreibung;
            tb_email.Text = ((dispos)cb_dispo_auswahl.SelectedItem).prop_dispomail;
            cb_email_normal.Checked = ((dispos)cb_dispo_auswahl.SelectedItem).prop_email_n;
            cb_email_eskalation.Checked = ((dispos)cb_dispo_auswahl.SelectedItem).prop_email_eskalation;
            cb_FRU.Checked = ((dispos)cb_dispo_auswahl.SelectedItem).prop_fru;
            cb_partner.Checked = ((dispos)cb_dispo_auswahl.SelectedItem).prop_partner;
        }

        private void bt_speichern_Click(object sender, EventArgs e)
        {
            ((dispos)cb_dispo_auswahl.SelectedItem).prop_name = tb_name.Text;
            ((dispos)cb_dispo_auswahl.SelectedItem).prop_beschreibung = tb_Beschreibung.Text;
            ((dispos)cb_dispo_auswahl.SelectedItem).prop_dispomail = tb_email.Text;
            ((dispos)cb_dispo_auswahl.SelectedItem).prop_email_n = cb_email_normal.Checked;
            ((dispos)cb_dispo_auswahl.SelectedItem).prop_email_eskalation = cb_email_eskalation.Checked;
            ((dispos)cb_dispo_auswahl.SelectedItem).prop_fru = cb_FRU.Checked;
            ((dispos)cb_dispo_auswahl.SelectedItem).prop_partner = cb_partner.Checked;
            sql_dispos.update_dispo((dispos)cb_dispo_auswahl.SelectedItem);
            aktualisieren();
        }

        private void bt_loeschen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten sie wirklich die Dispo löschen?", "Sind sie sicher?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sql_dispos.del_dispo((dispos)cb_dispo_auswahl.SelectedItem);
                aktualisieren();
            }
        }
    }
}
