using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unify_DPO_Tool
{
    class fru_preufen
    {
        public static string abfragen(int plz)
        {
            string erg = "";
            //Suchschema nach PLZ aus Excel Dokument in G-DMS zur FRU Verteilung
                //FRU1
                if (plz < 35000 || plz >= 37000 && plz < 40000 || plz >=98000 && plz < 100000)
                {
                    erg = "FRU1";
                }
                //FRU2
                else if (plz >= 40000 && plz < 54000 || plz >= 57000 && plz < 60000)
                {
                    erg = "FRU2";
                }
                //FRU3
                else if (plz >= 35000 && plz < 37000 || plz >= 54000 && plz < 57000 || plz >= 60000 && plz < 80000)
                {
                    erg = "FRU3";
                }
                //FRU4
                else if (plz >= 80000 && plz < 98000)
                {
                    erg = "FRU4";
                }
                //Nicht in BRD -> Wird nach neuem Suchschema vermutlich nicht mehr zutreffen
                else if (plz == 87491 || plz >= 87567 && plz <= 87569)
                {
                    erg = "Diese Postleitzahl ist nicht in der Bundesrepublik Deutschland.";
                }
                return erg;
        }
    }
}
