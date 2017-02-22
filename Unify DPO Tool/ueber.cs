using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unify_DPO_Tool
{
    public partial class ueber : Form
    {
        string mailtodeveloper = "mailto:peter.olfen@atos.net?subject=Unify DPO Tool";
        public ueber()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(mailtodeveloper);
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
