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
        private string name;
        private string rufnummer;
        private int dispo;
        public int prop_id
        {
            get { return id; }
            set { id = value; }
        }

        public string prop_name
        {
            get { return name; }
            set { name = value; }
        }
        public string prop_tel
        {
            get { return rufnummer; }
            set { rufnummer = value; }
        }
        public int prop_dispo
        {
            get { return dispo; }
            set { dispo = value; }
        }
        public dispos_tel()
        { }
        public dispos_tel(int id, string name, string rufnummer, int dispo)
        {
            this.id=id;
            this.name = name;
            this.rufnummer = rufnummer;
            this.dispo = dispo;
        }
    }
}
