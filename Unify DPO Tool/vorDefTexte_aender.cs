using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Unify_DPO_Tool
{
    public partial class vorDefTexte_aendern : Form
    {
        public vorDefTexte_aendern(string einstellung)
        {
            InitializeComponent();
            ArrayList liste = new ArrayList();
            liste = sql_aufrufe.SQL_workgroupsabrufen();
            foreach (Workgroup element in liste)
                cb_workgroup.Items.Add(element);
            liste.Clear();
            if (einstellung=="sachnummern")
            {
                tb_Text.Visible = false;
                lb_text.Visible = false;
            }
            if (einstellung=="remote")
            {
                lb_Sachnummer.Visible = false;
                lb_sBeschreibung.Visible = false;
                liste = sql_aufrufe.SQL_multipletable("remoteactivity");
                foreach (a_texte element in liste)
                    cb_auswahl.Items.Add(element);
                liste.Clear();
            }
            if (einstellung=="field")
            {
                lb_Sachnummer.Visible = false;
                lb_sBeschreibung.Visible = false;
                liste = sql_aufrufe.SQL_multipletable("reqactionfield");
                foreach (a_texte element in liste)
                    cb_auswahl.Items.Add(element);
                liste.Clear();
            }
        }
    }
}
