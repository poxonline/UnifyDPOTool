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
    public partial class user : Form
    {
        ArrayList userliste = new ArrayList();
        public user()
        {
            InitializeComponent();
            userliste = sql_aufrufe.SQL_userabrufen();
            foreach(users element in userliste)
            {
                cb_userauswahl.Items.Add(element);
            }
        }

        private void cb_userauswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_id.Text = Convert.ToString(((users)cb_userauswahl.SelectedItem).prop_id);
            tb_windowsk.Text = ((users)cb_userauswahl.SelectedItem).prop_windowsk;
            tb_name.Text = ((users)cb_userauswahl.SelectedItem).prop_name;
            cb_recht.SelectedItem = ((users)cb_userauswahl.SelectedItem).prop_recht;
            tb_passwort.Text = "";
        }
    }
}
