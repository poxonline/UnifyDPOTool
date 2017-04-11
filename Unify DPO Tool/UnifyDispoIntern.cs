using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unify_DPO_Tool
{
    public partial class UnifyDispoIntern : Form
    {
        public UnifyDispoIntern()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("tel:+4989700720192");
            }
            catch
            {
                MessageBox.Show("Es wurde kein passendes Programm zum Anrufen gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("tel:+4989700723640");
            }
            catch
            {
                MessageBox.Show("Es wurde kein passendes Programm zum Anrufen gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("tel:+4989700720192");
            }
            catch
            {
                MessageBox.Show("Es wurde kein passendes Programm zum Anrufen gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("tel:+4989700723061");
            }
            catch
            {
                MessageBox.Show("Es wurde kein passendes Programm zum Anrufen gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
