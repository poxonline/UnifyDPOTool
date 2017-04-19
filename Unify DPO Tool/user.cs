using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;

namespace Unify_DPO_Tool
{
    public partial class user : Form
    {
        ArrayList userliste = new ArrayList();
        public user(string typ)
        {
            InitializeComponent();
            if(typ=="neu")
            {
                cb_userauswahl.Visible = false;
                bt_pw_setzen.Visible = false;
                bt_user_loeschen.Visible = false;
                bt_edit.Visible = false;
            }
            else
            {
                bt_user_anlegen.Visible = false;
                userliste = sql_aufrufe.SQL_userabrufen();
                foreach (users element in userliste)
                    cb_userauswahl.Items.Add(element);
            }
        }

        private void cb_userauswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_id.Text = Convert.ToString(((users)cb_userauswahl.SelectedItem).prop_id);
            tb_windowsk.Text = ((users)cb_userauswahl.SelectedItem).prop_windowsk;
            tb_name.Text = ((users)cb_userauswahl.SelectedItem).prop_name;
            cb_recht.SelectedItem = Convert.ToString(((users)cb_userauswahl.SelectedItem).prop_recht);
            tb_passwort.Text = "";
        }

        private void bt_schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_user_anlegen_Click(object sender, EventArgs e)
        {
            users useradd = new users();
            useradd.prop_name = tb_name.Text;
            useradd.prop_windowsk = tb_windowsk.Text;
            useradd.prop_recht = Convert.ToInt32(cb_recht.SelectedItem);
            useradd.prop_pw = sql_aufrufe.GetSHA256Hash(tb_passwort.Text);
            sql_aufrufe.SQL_benutzeradd(useradd);
            useradd = null;
        }

        private void bt_user_loeschen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten sie wirklich den Benutzer löschen?", "Sind sie sicher?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sql_aufrufe.SQL_benutzerdel(((users)cb_userauswahl.SelectedItem).prop_id);
                aktualiasieren();
            }
        }

        private void bt_pw_setzen_Click(object sender, EventArgs e)
        {
            sql_aufrufe.SQL_benutzer_pwedit(((users)cb_userauswahl.SelectedItem).prop_id, sql_aufrufe.GetSHA256Hash(tb_passwort.Text));
            aktualiasieren();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            ((users)cb_userauswahl.SelectedItem).prop_name = tb_name.Text;
            ((users)cb_userauswahl.SelectedItem).prop_windowsk = tb_windowsk.Text;
            ((users)cb_userauswahl.SelectedItem).prop_recht = Convert.ToInt32(cb_recht.SelectedItem);
            sql_aufrufe.SQL_benutzer_edit_ohne_pw((users)cb_userauswahl.SelectedItem);
            aktualiasieren();
        }
        private void aktualiasieren()
        {
            cb_userauswahl.Items.Clear();
            userliste.Clear();
            tb_id.Text = "";
            tb_name.Text = "";
            tb_passwort.Text = "";
            tb_windowsk.Text = "";
            cb_recht.SelectedIndex = -1;
            userliste = sql_aufrufe.SQL_userabrufen();
            foreach (users element in userliste)
                cb_userauswahl.Items.Add(element);
        }
    }
}
