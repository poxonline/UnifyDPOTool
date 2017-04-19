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
            int plz;
            try
            {
                plz = Convert.ToInt32(textBox1.Text);
                //FRU1
                if (plz >= 1001 && plz <= 27499 || plz >= 29401 && plz <= 29416 || plz >= 34001 && plz <= 34399 || plz >= 34441 && plz <= 36469||plz>=37201&&plz<=37359||plz>=38481&&plz<=39649||plz>=96501&&plz<=96529||plz>=98501&&plz<=99998)
                {
                    erg.Text = "Ergebnis: FRU1";
                }
                //FRU2
                else if (plz >= 27501 && plz <= 27580 || plz >= 28001 && plz <= 29399 || plz >= 29431 && plz <= 33829 || plz >= 34401 && plz <= 34439||plz>=37001&&plz<=37199||plz>=37401&&plz<=38479||plz>=40001&&plz<=59969||plz>=60001&&plz<=63699)
                {
                    erg.Text = "Ergebnis: FRU2";
                }
                //FRU3
                else if(plz>=64201&&plz<=69518||plz>=70001&&plz<=74592||plz>=74594&&plz<=79879||plz>=88001&&plz<=88099||plz>=88181&&plz<=89085||plz>=89090&&plz<=89198||plz>=89501&&plz<=89619)
                {
                    erg.Text="Ergebnis: FRU3";
                }
                //FRU4
                else if(plz>=63701&&plz<=63774||plz>=63776&&plz<=63939||plz>=80001&&plz<=87490||plz>=87493&&plz<=87561||plz>=87571&&plz<=87789||plz>=88101&&plz<=88179||plz==89087||plz>=89201&&plz<=89449||plz>=90001&&plz<=96489||plz>=97001&&plz<=97999)
                {
                    erg.Text="Ergebnis: FRU4";
                }
                //Nicht in BRD
                else if(plz==87491||plz>=87567&&plz<=87569)
                {
                     erg.Text="Diese Postleitzahl ist nicht in der Bundesrepublik Deutschland.";
                }
                else
                {
                    erg.Text="Keine gültige Postleitzahl";
                }
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
