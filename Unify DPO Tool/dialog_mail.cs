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
    public partial class dialog_mail : Form
    {
        public string Return1 { get; set; }
        public dialog_mail(string typ)
        {
            InitializeComponent();
            label1.Text = typ+":";
            tb_wert.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Return1 = tb_wert.Text;
            DialogResult = DialogResult.OK;
        }

        private void tb_wert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender as Object, e as EventArgs);
            }
        }
    }
}
