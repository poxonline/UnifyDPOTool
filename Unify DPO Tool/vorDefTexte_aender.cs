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
        public vorDefTexte_aendern(string einstellung)
        {
            InitializeComponent();
            modi = einstellung;
            MessageBox.Show("Bearbeiten und Löschen ist aktuell noch nicht möglich!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                sql_aufrufe.SQL_sparepart_add(new spareparts(999, tb_sname.Text, tb_sBeschreibung.Text, Convert.ToString(cb_workgroup.SelectedText)));
            }
            if (modi == "remote")
            {
                sql_aufrufe.SQL_remote_add(new a_texte(999, tb_Text.Text, Convert.ToString(cb_workgroup.SelectedText)));
            }
            if (modi == "field")
            {
                sql_aufrufe.SQL_field_add(new a_texte(999, tb_Text.Text, Convert.ToString(cb_workgroup.SelectedText)));
            }
            update();
        }

        private void bt_speichern_Click(object sender, EventArgs e)
        {
            if (modi == "sachnummern")
            {
            }
            if (modi == "remote")
            {
            }
            if (modi == "field")
            {
            }
            update();
        }

        private void bt_loeschen_Click(object sender, EventArgs e)
        {
            if (modi == "sachnummern")
            {
            }
            if (modi == "remote")
            {
            }
            if (modi == "field")
            {
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
                cb_workgroup.SelectedItem = cb_workgroup.FindString(((spareparts)cb_auswahl.SelectedItem).prop_workgroup);
            }
            if (modi == "remote" || modi == "field")
            {
                tb_id.Text = Convert.ToString(((a_texte)cb_auswahl.SelectedItem).prop_id);
                tb_Text.Text = ((a_texte)cb_auswahl.SelectedItem).prop_text;
                cb_workgroup.SelectedItem = cb_workgroup.FindString(((a_texte)cb_auswahl.SelectedItem).prop_wg);
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
            GC.Collect(); // Test mit Garbage Collection
        }
    }
}
