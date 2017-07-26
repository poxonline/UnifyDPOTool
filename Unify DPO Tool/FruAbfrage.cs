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
    public partial class FruAbfrage : Form
    {
        public FruAbfrage()
        {
            InitializeComponent();
        }

        private void bt_abfrage_Click(object sender, EventArgs e)
        {
            try
            {
                erg.Text = "Ergebnis "+fru_preufen.abfragen(Convert.ToInt32(textBox1.Text));
            }
            catch
            {
                erg.Text= "Keine gültige Zahl.";
            }
        }

        private void bt_schliesen_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_abfrage_Click(sender as Object, e as EventArgs);
            }
        }
    }
}
