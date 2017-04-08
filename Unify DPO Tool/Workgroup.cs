using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unify_DPO_Tool
{
    class Workgroup
    {
        private int id;
        private string name;

        public Workgroup()
        {

        }
        public Workgroup(int u_id,string u_name)
        {
            id = u_id;
            name = u_name;
        }

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
        
        public override string ToString()
        {
            return name;
        }
    }
}
