using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Unify_DPO_Tool
{
    public partial class gruppeaendern : Form
    {
        static string ordner = Environment.GetEnvironmentVariable("userprofile") + "\\DPOToolSettings";
        static string gruppenconf = ordner + "\\gruppe.conf";
        string vorher = "";
        public gruppeaendern()
        {
            InitializeComponent();
        }

        private void gruppeaendern_Load(object sender, EventArgs e)
        {
            FileStream Pfad = new FileStream(gruppenconf, FileMode.Open, FileAccess.Read);
            StreamReader lesen = new StreamReader(gruppenconf);
            while (!lesen.EndOfStream)
            {
                vorher = lesen.ReadLine();
            }
            lesen.Close();
            Pfad.Close();
            if(vorher==dataNetzplan.Text)
            {
                dataNetzplan.Checked = true;
            }
            if(vorher==dataSLA.Text)
            {
                dataSLA.Checked = true;
            }
            if(vorher==data.Text)
            {
                data.Checked = true;
            }
            if(vorher==voice.Text)
            {
                voice.Checked = true;
            }
            if(vorher==uc.Text)
            {
                uc.Checked = true;
            }
            if(vorher==security.Text)
            {
                security.Checked = true;
            }
        }

        private void speichern_Click(object sender, EventArgs e)
        {
            FileStream Pfad = new FileStream(gruppenconf, FileMode.Create, FileAccess.Write);
            StreamWriter schreiben = new StreamWriter(Pfad);
            if (dataNetzplan.Checked) { schreiben.WriteLine(dataNetzplan.Text); }
            if (dataSLA.Checked) { schreiben.WriteLine(dataSLA.Text); }
            if (data.Checked) { schreiben.WriteLine(data.Text); }
            if (voice.Checked) { schreiben.WriteLine(voice.Text); }
            if (uc.Checked) { schreiben.WriteLine(uc.Text); }
            if (security.Checked) { schreiben.WriteLine(security.Checked); }
            schreiben.Close();
            Pfad.Close();
            this.Close();
        }

        private void abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
