using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Unify_DPO_Tool
{
    public partial class vorDefTexte_aendern : Form
    {
        static string modi = "";
        static Form1 hauptfenster;
        public vorDefTexte_aendern(string einstellung,Form1 u_hauptfenster)
        {
            InitializeComponent();
            hauptfenster = u_hauptfenster;
            modi = einstellung;
            ArrayList liste = new ArrayList();
            liste = sql_aufrufe.SQL_workgroupsabrufen();
            foreach (Workgroup element in liste)
                cb_workgroup.Items.Add(element);
            liste.Clear();
            if (einstellung=="sachnummern")
            {
                tb_Text.Visible = false;
                lb_text.Visible = false;
                liste = sql_aufrufe.SQL_req_sparepart();
                foreach (spareparts element in liste)
                    cb_auswahl.Items.Add(element);
                liste.Clear();
            }
            if (einstellung=="remote")
            {
                lb_Sachnummer.Visible = false;
                lb_sBeschreibung.Visible = false;
                tb_sname.Visible = false;
                tb_sBeschreibung.Visible = false;
                liste = sql_aufrufe.SQL_sel_multiple_table_wo_filter("remoteactivity");
                foreach (a_texte element in liste)
                    cb_auswahl.Items.Add(element);
                liste.Clear();
            }
            if (einstellung=="field")
            {
                lb_Sachnummer.Visible = false;
                lb_sBeschreibung.Visible = false;
                tb_sname.Visible = false;
                tb_sBeschreibung.Visible = false;
                liste = sql_aufrufe.SQL_sel_multiple_table_wo_filter("reqactionfield");
                foreach (a_texte element in liste)
                    cb_auswahl.Items.Add(element);
                liste.Clear();
            }
        }

        private void bt_anlegen_Click(object sender, EventArgs e)
        {
            if (modi == "sachnummern")
            {
                if (tb_sname.Text != "" && cb_workgroup.SelectedIndex!=-1)
                { sql_aufrufe.SQL_sparepart_add(new spareparts(999, tb_sname.Text, tb_sBeschreibung.Text, ((Workgroup)cb_workgroup.SelectedItem).prop_name)); }
                else
                {
                    MessageBox.Show("Bitte Feld Sachnummer ausfüllen und Workgroup wählen");
                }
            }
            if (modi == "remote")
            {
                if (tb_Text.Text != "" && cb_workgroup.SelectedIndex != -1)
                { sql_aufrufe.SQL_remote_add(new a_texte(999, tb_Text.Text, ((Workgroup)cb_workgroup.SelectedItem).prop_name)); }
                else
                {
                    MessageBox.Show("Bitte Feld Text ausfüllen und Workgroup wählen");
                }
            }
            if (modi == "field")
            {
                if (tb_Text.Text != "" && cb_workgroup.SelectedIndex != -1)
                { sql_aufrufe.SQL_field_add(new a_texte(999, tb_Text.Text, ((Workgroup)cb_workgroup.SelectedItem).prop_name)); }
                else
                {
                    MessageBox.Show("Bitte Feld Text ausfüllen und Workgroup wählen");
                }
            }
            update();
        }

        private void bt_speichern_Click(object sender, EventArgs e)
        {
            if (modi == "sachnummern")
            {
                if (tb_sname.Text != "" && cb_workgroup.SelectedIndex != -1)
                {
                    ((spareparts)cb_auswahl.SelectedItem).prop_sach = tb_sname.Text;
                    ((spareparts)cb_auswahl.SelectedItem).prop_beschreibung = tb_sBeschreibung.Text;
                    ((spareparts)cb_auswahl.SelectedItem).prop_workgroup = cb_workgroup.Text;
                    sql_aufrufe.SQL_spareparts_edit((spareparts)cb_auswahl.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Bitte Feld Sachnummer ausfüllen und Workgroup wählen");
                }
            }
            if (modi == "remote")
            {
                if (tb_Text.Text != "" && cb_workgroup.SelectedIndex != -1)
                {
                    ((a_texte)cb_auswahl.SelectedItem).prop_text = tb_Text.Text;
                    ((a_texte)cb_auswahl.SelectedItem).prop_wg = cb_workgroup.Text;
                    sql_aufrufe.SQL_remote_edit((a_texte)cb_auswahl.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Bitte Feld Text ausfüllen und Workgroup wählen");
                }
            }
            if (modi == "field")
            {
                if (tb_Text.Text != "" && cb_workgroup.SelectedIndex != -1)
                {
                    ((a_texte)cb_auswahl.SelectedItem).prop_text = tb_Text.Text;
                    ((a_texte)cb_auswahl.SelectedItem).prop_wg = cb_workgroup.Text;
                    sql_aufrufe.SQL_field_edit((a_texte)cb_auswahl.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Bitte Feld Text ausfüllen und Workgroup wählen");
                }
            }
            update();
        }

        private void bt_loeschen_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (modi == "sachnummern")
            {
               result=MessageBox.Show("Möchten sie wirklich das Ersatzteil " + ((spareparts)cb_auswahl.SelectedItem).prop_beschreibung + " löschen?", "Sind sie sicher?", MessageBoxButtons.YesNo);
               if (result == DialogResult.Yes)
               {
                   sql_aufrufe.SQL_sparepart_del((spareparts)cb_auswahl.SelectedItem);
               }
            }
            if (modi == "remote")
            {
                result = MessageBox.Show("Möchten sie wirklich den ausgewählten Text löschen?", "Sind sie sicher?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sql_aufrufe.SQL_remotetext_del((a_texte)cb_auswahl.SelectedItem);
                }
            }
            if (modi == "field")
            {
                result = MessageBox.Show("Möchten sie wirklich den ausgewählten Text löschen?", "Sind sie sicher?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sql_aufrufe.SQL_fieldtext_del((a_texte)cb_auswahl.SelectedItem);
                }
            }
            update();
        }

        private void cb_auswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modi == "sachnummern")
            {
                tb_id.Text=Convert.ToString(((spareparts)cb_auswahl.SelectedItem).prop_id);
                tb_sname.Text = ((spareparts)cb_auswahl.SelectedItem).prop_sach;
                tb_sBeschreibung.Text = ((spareparts)cb_auswahl.SelectedItem).prop_beschreibung;
                cb_workgroup.SelectedIndex = cb_workgroup.FindString(((spareparts)cb_auswahl.SelectedItem).prop_workgroup);
            }
            if (modi == "remote" || modi == "field")
            {
                tb_id.Text = Convert.ToString(((a_texte)cb_auswahl.SelectedItem).prop_id);
                tb_Text.Text = ((a_texte)cb_auswahl.SelectedItem).prop_text;
                cb_workgroup.SelectedIndex = cb_workgroup.FindString(((a_texte)cb_auswahl.SelectedItem).prop_wg);
            }
        }
        private void update()
        {
            ArrayList liste = new ArrayList();
            cb_auswahl.Items.Clear();
            if (modi == "sachnummern")
            {
                liste = sql_aufrufe.SQL_req_sparepart();
                foreach (spareparts element in liste)
                    cb_auswahl.Items.Add(element);
            }
            if (modi == "remote")
            {
                liste = sql_aufrufe.SQL_sel_multiple_table_wo_filter("remoteactivity");
                foreach (a_texte element in liste)
                    cb_auswahl.Items.Add(element);
            }
            if (modi == "field")
            {
                cb_auswahl.Items.Clear();
                liste = sql_aufrufe.SQL_sel_multiple_table_wo_filter("reqactionfield");
                foreach (a_texte element in liste)
                    cb_auswahl.Items.Add(element);
            }
            liste.Clear();
            tb_id.Text = "";
            tb_Text.Text = "";
            tb_sname.Text = "";
            tb_sBeschreibung.Text = "";
            cb_workgroup.SelectedIndex = -1;
            GC.Collect(); // Test mit Garbage Collection
        }

        private void vorDefTexte_aendern_FormClosed(object sender, FormClosedEventArgs e)
        {
            hauptfenster.felderreload();   
        }
    }
}
