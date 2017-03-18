﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Unify_DPO_Tool
{
    public partial class team_form : Form
    {
        ArrayList teams = new ArrayList();
        ArrayList groups = new ArrayList();
        public team_form(string modus)
        {
            InitializeComponent();
            if(modus=="neu")
            {
                cb_teamauswahl.Visible = false;
                bt_speichern.Visible = false;
                bt_loeschen.Visible = false;
            }
            else
            {
                lb_autohinweis.Visible = false;
                bt_anlegen.Visible = false;
                teams = sql_aufrufe.SQL_teamsabrufen();
                foreach(team element in teams)
                {
                    cb_teamauswahl.Items.Add(element);
                }
            }
            groups = sql_aufrufe.SQL_workgroupsabrufen();
            foreach(Workgroup element in groups)
            {
                cb_workgroupauswahl.Items.Add(element);
            }
            teams.Clear();
            groups.Clear();
        }

        private void bt_anlegen_Click(object sender, EventArgs e)
        {

        }

        private void bt_speichern_Click(object sender, EventArgs e)
        {

            update_teams();
        }

        private void bt_loeschen_Click(object sender, EventArgs e)
        {

        }

        private void cb_teamauswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_id.Text = Convert.ToString(((team)cb_teamauswahl.SelectedItem).prop_id);
            tb_anzeige_name.Text = ((team)cb_teamauswahl.SelectedItem).prop_name;
            tb_email.Text = ((team)cb_teamauswahl.SelectedItem).prop_email;
            tb_hotliner.Text = ((team)cb_teamauswahl.SelectedItem).prop_telefon;
            tb_modmail.Text = ((team)cb_teamauswahl.SelectedItem).prop_modemail;
            tb_zusatztext.Text = ((team)cb_teamauswahl.SelectedItem).prop_zusatztext;
            cb_workgroupauswahl.SelectedItem = Convert.ToString(((team)cb_teamauswahl.SelectedItem).prop_workgroup);
            tb_lastedit.Text = Convert.ToString(((team)cb_teamauswahl.SelectedItem).prop_lastmod);
        }
        public void update_teams()
        {
            ArrayList teams = new ArrayList();
            teams = sql_aufrufe.SQL_teamsabrufen();
            foreach (team element in teams)
            {
                cb_teamauswahl.Items.Add(element);
            }
            teams.Clear();
        }
    }
}
