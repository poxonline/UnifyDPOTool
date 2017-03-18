﻿using System;
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
        private string kuerzel;

        public Workgroup()
        {

        }
        public Workgroup(int u_id,string u_name,string u_kuerzel)
        {
            id = u_id;
            name = u_name;
            kuerzel = u_kuerzel;
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

        public string prop_kuerzel
        {
            get { return kuerzel; }
            set { kuerzel = value; }
        }
        
        
        
        public override string ToString()
        {
            return name;
        }
    }
}