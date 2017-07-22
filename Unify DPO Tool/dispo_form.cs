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
    public partial class dispo_form : Form
    {
        public dispo_form()
        {
            InitializeComponent();
            aktualisieren();
        }
        public void aktualisieren()
        {
            cb_dispo_auswahl.Items.Clear();
            tb_id.Text = "";
            tb_name.Text = "";
            tb_Beschreibung.Text = "";
            tb_email.Text = "";
            cb_FRU.Checked = false;
            cb_email_normal.Checked = false;
            cb_email_eskalation.Checked = false;
            cb_partner.Checked = false;
            ArrayList dispoliste = new ArrayList();
            dispoliste = sql_dispos.select_dispos();
            foreach(dispos element in dispoliste)
            {
                cb_dispo_auswahl.Items.Add(element);
            }
        }
    }
}
