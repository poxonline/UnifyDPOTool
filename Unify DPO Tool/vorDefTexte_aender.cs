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
    public partial class vorDefTexte_aendern : Form
    {

        static string ordner = Environment.GetEnvironmentVariable("userprofile") + "\\DPOToolSettings";
        static string ConfigPfad = "";
        public vorDefTexte_aendern(string einstellung)
        {
            InitializeComponent();
            if (einstellung == ordner + "\\sachnummern.conf")
            {
                this.Text = "Vordefinierte Sachnummern bearbeiten";
            }
            if (einstellung == ordner + "\\actionremote.conf")
            {
                this.Text = "Vordefinierte \"Action so far in Remote\" bearbeiten";
            }
            if (einstellung == ordner + "\\requestedfromfield.conf")
            {
                this.Text = "Vordefinierte \"Requested Action from Field\" bearbeiten";
            }
            ConfigPfad = einstellung;
            string gelesen = "";
            FileStream Pfad = new FileStream(ConfigPfad, FileMode.Open, FileAccess.Read);
            StreamReader lesen = new StreamReader(Pfad);
            gelesen = lesen.ReadLine();
            while(!lesen.EndOfStream)
            {
                gelesen = gelesen + "\n" + lesen.ReadLine();
            }
            lesen.Close();
            Pfad.Close();
            VorDefText.Text = gelesen;
        }

        private void speichern_Click(object sender, EventArgs e)
        {
            FileStream Pfad = new FileStream(ConfigPfad, FileMode.Create, FileAccess.Write);
            StreamWriter schreiben = new StreamWriter(Pfad);
            schreiben.Write(VorDefText.Text);
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
