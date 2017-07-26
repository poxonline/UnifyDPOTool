using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unify_DPO_Tool
{
    class dispos_tel
    {
        private int id;
        private string beschreibung;
        private string rufnummer;
        private string dispo;
        public int prop_id
        {
            get { return id; }
            set { id = value; }
        }

        public string prop_beschreibung
        {
            get { return beschreibung; }
            set { beschreibung = value; }
        }
        public string prop_tel
        {
            get { return rufnummer; }
            set { rufnummer = value; }
        }
        public string prop_dispo
        {
            get { return dispo; }
            set { dispo = value; }
        }
        public dispos_tel()
        { }
        public dispos_tel(int id, string beschreibung, string rufnummer, string dispo)
        {
            this.id=id;
            this.beschreibung = beschreibung;
            this.rufnummer = rufnummer;
            this.dispo = dispo;
        }
        public override string ToString()
        {
            return beschreibung;
        }
    }
}
