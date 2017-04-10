using System;
using System.Collections.Generic;
using System.Collections;
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
            ArrayList teams = new ArrayList();
            teams = sql_aufrufe.SQL_teamsabrufen();
            foreach (team element in teams)
                cb_groupwahlfest.Items.Add(element);
            teams.Clear();
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
            cb_groupwahlfest.SelectedIndex = cb_groupwahlfest.FindString(vorher);
        }

        private void speichern_Click(object sender, EventArgs e)
        {
            FileStream Pfad = new FileStream(gruppenconf, FileMode.Create, FileAccess.Write);
            StreamWriter schreiben = new StreamWriter(Pfad);
            schreiben.WriteLine(cb_groupwahlfest.SelectedItem.ToString());
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
