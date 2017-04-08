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
    public partial class workgroup_form : Form
    {
        public workgroup_form(string modus)
        {
            if(modus=="neu")
            {
                bt_speichern.Visible = false;
                bt_del.Visible = false;
            }
            else
            {
                bt_anlegen.Visible = false;
            }
            InitializeComponent();
        }

        private void bt_anlegen_Click(object sender, EventArgs e)
        {
            Workgroup wg = new Workgroup();
            wg.prop_name = tb_workgroup.Text;
            sql_aufrufe.SQL_wgadd(wg);
        }

        private void bt_speichern_Click(object sender, EventArgs e)
        {
            ((Workgroup)cb_workgauswahl.SelectedItem).prop_name = tb_workgroup.Text;
            sql_aufrufe.SQL_wgedit((Workgroup)cb_workgauswahl.SelectedItem);
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            sql_aufrufe.SQL_wgdel((Workgroup)cb_workgauswahl.SelectedItem);
        }
        private void update_workgroups()
        {
            cb_workgauswahl.Items.Clear();
        }
    }
}
