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
    public partial class dispo_tel_form : Form
    {
        public dispo_tel_form()
        {
            InitializeComponent();
            aktualisieren();
        }
        public void aktualisieren()
        {
            cb_tel_auswahl.Items.Clear();
            cb_dispo.Items.Clear();
            tb_id.Text = "";
            tb_Beschreibung.Text = "";
            tb_rufnummer.Text = "";
            ArrayList rufnummern = new ArrayList();
            rufnummern = sql_dispos.select_dispo_tel();
            foreach(dispos_tel element in rufnummern)
            {
                cb_tel_auswahl.Items.Add(element);
            }
            rufnummern.Clear();
            ArrayList dispo = new ArrayList();
            dispo=sql_dispos.select_dispos();
            foreach(dispos element in dispo)
            {
                cb_dispo.Items.Add(element);
            }
            dispo.Clear();
        }

        private void bt_anlegen_Click(object sender, EventArgs e)
        {
            sql_dispos.add_disp_tel(new dispos_tel(0, tb_Beschreibung.Text, tb_rufnummer.Text, ((dispos)cb_dispo.SelectedItem).prop_id));
            aktualisieren();
        }

        private void bt_speichern_Click(object sender, EventArgs e)
        {
            ((dispos_tel)cb_tel_auswahl.SelectedItem).prop_beschreibung = tb_Beschreibung.Text;
            ((dispos_tel)cb_tel_auswahl.SelectedItem).prop_tel = tb_rufnummer.Text;
            ((dispos_tel)cb_tel_auswahl.SelectedItem).prop_dispo = ((dispos)cb_dispo.SelectedItem).prop_id;
            sql_dispos.update_dispo_tel((dispos_tel)cb_tel_auswahl.SelectedItem);
            aktualisieren();
        }

        private void bt_loeschen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten sie wirklich den Benutzer löschen?", "Sind sie sicher?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sql_dispos.del_dispo_tel((dispos_tel)cb_tel_auswahl.SelectedItem);
                aktualisieren();
            }
        }

        private void cb_tel_auswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_id.Text=Convert.ToString(((dispos_tel)cb_tel_auswahl.SelectedItem).prop_id);
            tb_Beschreibung.Text=((dispos_tel)cb_tel_auswahl.SelectedItem).prop_beschreibung;
            tb_rufnummer.Text=((dispos_tel)cb_tel_auswahl.SelectedItem).prop_tel;
            //Hier muss noch ergänzt werden das die zugehörige Dispo ausgewählt wird!!
        }
    }
}
