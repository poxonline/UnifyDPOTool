using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unify_DPO_Tool
{
    class asp
    {
        //Test2
        private int id;
        private string name;
        private string email;
        private string rufnummer; 

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
        public string prop_mail
        {
            get { return email; }
            set { email = value; }
        }
        public string prop_tel
        {
            get { return rufnummer; }
            set { rufnummer = value; }
        }

        public asp()
        { }
        public asp(int u_id,string u_name, string u_mail, string u_rufnummer)
        {
            id = u_id;
            name = u_name;
            email = u_mail;
            rufnummer = u_rufnummer;
        }
        public override string ToString()
        {
            return name;
        }
        
    }
}
