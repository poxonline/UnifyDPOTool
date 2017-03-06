using System;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;

namespace Unify_DPO_Tool
{
    class sql_aufrufe
    {
        //user=dbname
        //Passwort: dpotooldb123!.
        static string connection = "SERVER=wo-x-pictures.de;DATABASE=dpotooldb;UID=dpotooldb;PASSWORD=123456;";
        /// <summary>
        /// MD5 Hash erzeugen und als string zurückgeben.
        /// </summary>
        /// <param name="md5Hash">md5Hash Objekt</param>
        /// <param name="input">Passwort das als MD5 umgeandelt werden soll.</param>
        /// <returns>String mit MD5 vom Passwortfeld als Inhalt</returns>
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
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
        public static ArrayList SQL_teamsabrufen()
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT * from teams;", verbindung);
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
                        liste.Add(new team(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6), rdr.GetDateTime(7)));
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
        public static ArrayList SQL_userabrufen()
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT * from benutzer", verbindung);
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
                        liste.Add(new users(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(3), rdr.GetString(4)));
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
