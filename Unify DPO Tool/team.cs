using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unify_DPO_Tool
{
    class team
    {
        private int id;
        private string name;
        private string telefon;
        private string email;
        private string modemail;
        private string workgroup;
        private string zusatztext;
        private DateTime lastmod;
        public team()
        { }
        public team(int u_id,string u_name,string u_telefon,string u_email, string u_modmail,string u_workgroup, string u_zusatz,DateTime u_lastmod)
        {
            id = u_id;
            name = u_name;
            telefon = u_telefon;
            email = u_email;
            modemail = u_modmail;
            workgroup = u_workgroup;
            zusatztext = u_zusatz;
            lastmod = u_lastmod;
        }
        public override string ToString()
        {
            return name;
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
        public string prop_telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        public string prop_email
        {
            get { return email; }
            set { email = value; }
        }
        public string prop_modemail
        {
            get { return modemail; }
            set { modemail = value; }
        }
        public string prop_workgroup
        {
            get { return workgroup; }
            set { workgroup = value; }
        }
        public string prop_zusatztext
        {
            get { return zusatztext; }
            set { zusatztext = value; }
        }
        public DateTime prop_lastmod
        {
            get { return lastmod; }
            set { lastmod = value; }
        }

    }
}
