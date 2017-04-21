using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unify_DPO_Tool
{
    public partial class setting_server : Form
    {
        public setting_server()
        {
            InitializeComponent();
            tb_server.Text = Properties.Settings.Default.server;
        }

        private void bt_test_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = tb_server.Text;
            sql_aufrufe.edit_con();
            bool testerg=sql_aufrufe.sql_verbindungstest();
            if(!testerg)
            {
                bt_test.BackColor = Color.Red;
            }
            else
            {
                bt_test.BackColor = Color.Green;
                Properties.Settings.Default.Save();
            }
                
        }

        private void bt_schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
