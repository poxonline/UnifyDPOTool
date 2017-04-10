using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unify_DPO_Tool
{
    class a_texte
    {
        private int id;
        private string text;
        private string workgroup;

        public int prop_id
        {
            get { return id; }
            set { id = value; }
        }
        public string prop_text
        {
            get { return text; }
            set { text = value; }
        }
        
        public a_texte()
        {

        }
        public a_texte(int u_id,string u_text,string u_wg)
        {
            id = u_id;
            text = u_text;
            workgroup = u_wg;
        }

        public override string ToString()
        {
            return text;
        }
    }
}
