using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unify_DPO_Tool
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (sql_aufrufe.sql_verbindungstest())
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Der Datenbankserver ist nicht erreichbar. Bitte im folgenden Fenster die Einstellungen prüfen und Anwendung neu starten.","Fehler bei der Datenbank Verbindung",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Run(new setting_server());
            }
        }
    }
}
