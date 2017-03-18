using System;
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
    }
}
