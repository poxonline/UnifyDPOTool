using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unify_DPO_Tool
{
    class users
    {
        private int id;
        private string windowsk;
        private string name;
        private int recht;
        private string passwort;

        public int prop_id
        {
            get { return id; }
            set { id = value; }
        }
        public string prop_windowsk
        {
            get { return windowsk; }
            set { windowsk = value; }
        }
        public string prop_name
        {
            get { return name; }
            set { name = value; }
        }
        public int prop_recht
        {
            get { return recht; }
            set { recht = value; }
        }
        public string prop_pw
        {
            get { return passwort; }
            set { passwort = value; }
        }
        public users()
        { }
        public users(int u_id,string u_windowsk,string u_name,int u_recht,string u_passwort)
        {
            id = u_id;
            windowsk = u_windowsk;
            name = u_name;
            recht = u_recht;
            passwort = u_passwort;
        }
        

        public override string ToString()
        {
            return name+"("+windowsk+")";
        }
    }
}
