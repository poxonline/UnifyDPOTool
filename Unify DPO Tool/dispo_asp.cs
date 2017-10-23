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
    public partial class dispo_asp : Form
    {
        public dispo_asp()
        {
            InitializeComponent();
            refresh_form();
        }

        public void refresh_form()
        {
            cb_list_asp.Items.Clear();
            clb_dispos.Items.Clear();
            cb_list_asp.Items.Add("Neu");
            ArrayList asps = sql_dispos.select_asp();
            if (asps != null)
            {
                foreach (asp element in asps)
                    cb_list_asp.Items.Add(element);
                asps.Clear();
            }
            tb_asp_id.Text = "";
            tb_asp_mail.Text = "";
            tb_asp_name.Text = "";
            tb_asp_tel.Text = "";
        }

        private void cb_list_asp_SelectedIndexChanged(object sender, EventArgs e)
        {
            clb_dispos.Items.Clear();
            ArrayList dispo = sql_dispos.select_dispos();
            if (cb_list_asp.Text == "Neu")
            {
                bt_asp_hinzu.Visible = true;
                bt_loeschen.Visible = false;
                bt_speichern.Visible = false;
                foreach (dispos element in dispo)
                {
                    clb_dispos.Items.Add(element);
                }
            }
            else
            {
                bt_asp_hinzu.Visible = false;
                bt_loeschen.Visible = true;
                bt_speichern.Visible = true;
                tb_asp_id.Text = Convert.ToString(((asp)cb_list_asp.SelectedItem).prop_id);
                tb_asp_name.Text = ((asp)cb_list_asp.SelectedItem).prop_name;
                tb_asp_mail.Text = ((asp)cb_list_asp.SelectedItem).prop_mail;
                tb_asp_tel.Text = ((asp)cb_list_asp.SelectedItem).prop_tel;
                ArrayList abgleich = new ArrayList();
                abgleich = sql_dispos.select_dispos_with_asp((asp)cb_list_asp.SelectedItem);
                foreach (dispos element in dispo)
                {
                    int index = clb_dispos.Items.Add(element);
                    foreach (string wert in abgleich)
                    {
                        if (element.prop_name == wert)
                        clb_dispos.SetItemChecked(index, true);
                    }
                }
            }
            dispo.Clear();
        }

        private void bt_asp_hinzu_Click(object sender, EventArgs e)
        {
            ArrayList uebergabe = new ArrayList();
            sql_dispos.add_dispo_asp(new asp(0, tb_asp_name.Text, tb_asp_mail.Text, tb_asp_tel.Text));
            foreach(object itemchecked in clb_dispos.CheckedItems)
            {
                uebergabe.Add(itemchecked);
            }
            sql_dispos.add_hilf_dispo(new asp(0, tb_asp_name.Text, tb_asp_mail.Text, tb_asp_tel.Text), uebergabe);
            refresh_form();
        }

        private void bt_speichern_Click(object sender, EventArgs e)
        {
            sql_dispos.del_hilf_dispo((asp)cb_list_asp.SelectedItem);
            ((asp)cb_list_asp.SelectedItem).prop_name = tb_asp_name.Text;
            ((asp)cb_list_asp.SelectedItem).prop_mail = tb_asp_mail.Text;
            ((asp)cb_list_asp.SelectedItem).prop_tel = tb_asp_tel.Text;
            sql_dispos.update_asp((asp)cb_list_asp.SelectedItem);
            ArrayList uebergabe = new ArrayList();
            foreach (object itemchecked in clb_dispos.CheckedItems)
            {
                uebergabe.Add(itemchecked);
            }
            sql_dispos.add_hilf_dispo(new asp(0, tb_asp_name.Text, tb_asp_mail.Text, tb_asp_tel.Text), uebergabe);
            refresh_form();
        }

        private void bt_loeschen_Click(object sender, EventArgs e)
        {
            sql_dispos.del_hilf_dispo((asp)cb_list_asp.SelectedItem);
            sql_dispos.del_asp((asp)cb_list_asp.SelectedItem);
        }
    }
}
