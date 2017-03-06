using System;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Unify_DPO_Tool
{
    class sql_aufrufe
    {
        //user=dbname
        //Passwort: dpotooldb123!.
        static string connection = "SERVER=wo-x-pictures.de;DATABASE=dpotooldb;UID=dpotooldb;PASSWORD=123456;";
        /// <summary>
        /// SQL Verbindung, mit Userpasswort abfrage.
        /// </summary>
        /// <param name="ue_user">Zu suchender User</param>
        /// <returns>Passwort aus DB als string</returns>
        public static string SQL_pwabfrage(string ue_user)
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    string gesamt = "";
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT passwort from benutzer where windowskennung=@user", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@user", ue_user);
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
                        gesamt = rdr.GetString(0);
                    }
                    rdr.Close();
                    verbindung.Close();
                    return gesamt;
                }
                catch
                {
                    MessageBox.Show("Fehler bei der Verbindung mit der Datenbank.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    verbindung.Close();
                }

            }
        }
        public static int SQL_benutzerrecht(string ue_user)
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                int gesamt = 0;
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT recht from benutzer where windowskennung=@user", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@user", ue_user);
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
                        gesamt = rdr.GetInt32(0);
                    }
                    rdr.Close();
                    verbindung.Close();
                    return gesamt;
                }
                catch
                {
                    MessageBox.Show("Fehler bei der Verbindung mit der Datenbank.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return gesamt;
                }
                finally
                {
                    verbindung.Close();
                }

            }
        }
        public static ArrayList SQL_teamsabrufen(string ue_user)
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT recht from benutzer where windowskennung=@user", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@user", ue_user);
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
                        
                    }
                    rdr.Close();
                    verbindung.Close();
                    return liste;
                }
                catch
                {
                    MessageBox.Show("Fehler bei der Verbindung mit der Datenbank.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
