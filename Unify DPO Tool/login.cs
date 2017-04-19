using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Collections;

namespace Unify_DPO_Tool
{
    public partial class login : Form
    {
        string wert, pw_rueckgabe;
        public string Return1 { get; set; }
        public int Return2 { get; set; }
        Form1 hauptfenster;
        public login(Form1 fenster)
        {
            InitializeComponent();
            tb_benutzer_ein.Text = Environment.UserName;
            hauptfenster = fenster;
            tb_pw_ein.Focus();
        }

        private void bt_abenutzer_Click(object sender, EventArgs e)
        {
            tb_benutzer_ein.Enabled = true;
            tb_benutzer_ein.Focus();

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            pw_rueckgabe = sql_aufrufe.SQL_pwabfrage(tb_benutzer_ein.Text);
            wert = sql_aufrufe.GetSHA256Hash(tb_pw_ein.Text);
            if (wert == pw_rueckgabe)
            {
                MessageBox.Show("Login erfolgreich","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Return1 = tb_benutzer_ein.Text;
                Return2 = sql_aufrufe.SQL_benutzerrecht(tb_benutzer_ein.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Login falsch!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tb_pw_ein.Text = "";
            }

        }

        private void tb_pw_ein_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                bt_login_Click(sender as Object, e as EventArgs);
            }
        }
    }
}
