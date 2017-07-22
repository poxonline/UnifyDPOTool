using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unify_DPO_Tool
{
    class dispos
    {
        private int id;
        private string name;
        private bool fru;
        private string dispomail;
        private bool EMail_ASP_normal;
        private bool EMAIL_ASP_eskalation;
        private string beschreibung;
        private bool partner;       

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
        public string prop_dispomail
        {
            get { return dispomail; }
            set { dispomail = value; }
        }
        public bool prop_fru
        {
            get { return fru; }
            set { fru = value; }
        }
        public bool prop_email_n
        {
            get { return EMail_ASP_normal; }
            set { EMail_ASP_normal = value; }
        }
        public bool prop_email_eskalation
        {
            get { return EMAIL_ASP_eskalation; }
            set { EMAIL_ASP_eskalation = value; }
        }
        public string prop_beschreibung
        {
            get { return beschreibung; }
            set { beschreibung = value; }
        }
        public bool prop_partner
        {
            get { return partner; }
            set { partner = value; }
        }
        public dispos()
        { }
        public dispos(int id, string name,string dispomail, bool fru,bool email_normal,bool email_eskalation,string beschreibung,bool partner)
        {
            this.id = id;
            this.name = name;
            this.dispomail = dispomail;
            this.fru = fru;
            this.EMail_ASP_normal = email_normal;
            this.EMAIL_ASP_eskalation = email_eskalation;
            this.beschreibung = beschreibung;
            this.partner = partner;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
