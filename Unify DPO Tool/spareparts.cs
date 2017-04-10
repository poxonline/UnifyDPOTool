using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unify_DPO_Tool
{
    class spareparts
    {
        private int id;
        private string sachnummer;
        private string beschreibung;
        private string workgroup;
        public spareparts()
        {

        }
        public spareparts(int u_id,string u_sach,string u_besch,string u_wg)
        {
            id = u_id;
            sachnummer = u_sach;
            beschreibung = u_besch;
            workgroup = u_wg;
        }
    }
}
