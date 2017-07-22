using System;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;
using System.DirectoryServices;

namespace Unify_DPO_Tool
{
    class sql_dispos
    {
        //Alle SQL Befehle im Zusammenahng mit Dispos und ASP
        static string connection = sql_aufrufe.connection;
        public static ArrayList select_dispos()
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT * from dispos;", verbindung);
                    ArrayList liste = new ArrayList();
                    try
                    {
                        verbindung.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    rdr = SQL_Befehl.ExecuteReader();
                    while (rdr.Read())
                    {
                        liste.Add(new dispos(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetBoolean(3), rdr.GetBoolean(4), rdr.GetBoolean(5), rdr.GetString(6), rdr.GetBoolean(7)));
                    }
                    rdr.Close();
                    verbindung.Close();
                    return liste;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler bei der Verbindung mit der Datenbank." + Environment.NewLine + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    verbindung.Close();
                }

            }
        }
    }
}
