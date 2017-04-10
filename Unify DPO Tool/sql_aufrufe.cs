using System;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;
using System.DirectoryServices;

namespace Unify_DPO_Tool
{
    class sql_aufrufe
    {
        static string connection = "SERVER=wo-x-pictures.de;DATABASE=dpotooldb;UID=dpotooldb;PASSWORD=123456;";
        static string connection_unused = "SERVER=mhhd0amc.global-ad.net;DATABASE=dpo;UID=dpo;PASSWORD=dpo123;";
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

        public static ArrayList SQL_workgroupsabrufen()
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT * from workgroups;", verbindung);
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
                        liste.Add(new Workgroup(rdr.GetInt32(0), rdr.GetString(1)));
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
        public static void SQL_benutzeradd(users useradd)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("INSERT INTO benutzer (windowskennung,name,recht,passwort) VALUES (@windows,@name,@recht,@passwort)", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@windows", useradd.prop_windowsk);
                    SQL_Befehl.Parameters.AddWithValue("@name", useradd.prop_name);
                    SQL_Befehl.Parameters.AddWithValue("@recht", useradd.prop_recht);
                    SQL_Befehl.Parameters.AddWithValue("@passwort", useradd.prop_pw);
                    try
                    {
                        SQL_Befehl.Connection.Open();
                        SQL_Befehl.ExecuteNonQuery();
                        SQL_Befehl.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Benutzer erfoglreich angelegt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("Es ist ein Fehler aufgetreten, der Benutzer konnte nicht angelegt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }

            }
        }
        public static void SQL_benutzerdel(int u_id)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("DELETE FROM benutzer where id=@uid", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@uid", u_id);
                    try
                    {
                        SQL_Befehl.Connection.Open();
                        SQL_Befehl.ExecuteNonQuery();
                        SQL_Befehl.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Benutzer erfoglreich gelöscht.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten, der Benutzer konnte nicht gelöscht werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }

            }
        }
        public static void SQL_benutzer_pwedit(int u_id,string u_pw)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("UPDATE benutzer SET passwort=@pw where id=@uid ", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@uid", u_id);
                    SQL_Befehl.Parameters.AddWithValue("@pw", u_pw);
                    try
                    {
                        SQL_Befehl.Connection.Open();
                        SQL_Befehl.ExecuteNonQuery();
                        SQL_Befehl.Connection.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    verbindung.Close();
                    MessageBox.Show("Benutzer PW erfoglreich gesetzt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten, das Benutzer PW konnte nicht gesetzt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }

            }
        }
        public static void SQL_benutzer_edit_ohne_pw(users useredit)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("UPDATE benutzer SET windowskennung=@windowsk, name=@nm, recht=@urecht where id=@uid ", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@uid", useredit.prop_id);
                    SQL_Befehl.Parameters.AddWithValue("@windowsk", useredit.prop_windowsk);
                    SQL_Befehl.Parameters.AddWithValue("@nm", useredit.prop_name);
                    SQL_Befehl.Parameters.AddWithValue("@urecht", useredit.prop_recht);
                    try
                    {
                        SQL_Befehl.Connection.Open();
                        SQL_Befehl.ExecuteNonQuery();
                        SQL_Befehl.Connection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    verbindung.Close();
                    MessageBox.Show("Benutzer erfoglreich ohne PW geändert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten, der Benutzer konnte nicht bearbeitet werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }

            }
        }
        public static void SQL_teamadd(team teamadd)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("INSERT INTO teams (name,hotlinetel,email,modmail,workgroup,speztext,lastmod) VALUES (@azeigname,@hotline,@mail,@modemail,@wgroup,@stext,@lastedit)", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@azeigname", teamadd.prop_name);
                    SQL_Befehl.Parameters.AddWithValue("@hotline", teamadd.prop_telefon);
                    SQL_Befehl.Parameters.AddWithValue("@mail", teamadd.prop_email);
                    SQL_Befehl.Parameters.AddWithValue("@modemail", teamadd.prop_modemail);
                    SQL_Befehl.Parameters.AddWithValue("@wgroup", teamadd.prop_workgroup);
                    SQL_Befehl.Parameters.AddWithValue("@stext", teamadd.prop_zusatztext);
                    SQL_Befehl.Parameters.AddWithValue("@lastedit", teamadd.prop_lastmod);
                    try
                    {
                        SQL_Befehl.Connection.Open();
                        SQL_Befehl.ExecuteNonQuery();
                        SQL_Befehl.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Team erfoglreich angelegt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("Es ist ein Fehler aufgetreten, das Team konnte nicht angelegt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }

            }
        }
        public static void SQL_teamedit(team teamadd)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("UPDATE teams  SET name=@anzeigname,hotlinetel=@hotline,email=@mail,modmail=@modemail,workgroup=@wgroup,speztext=@stext,lastmod=@lastedit WHERE ID=@tid", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@anzeigname", teamadd.prop_name);
                    SQL_Befehl.Parameters.AddWithValue("@hotline", teamadd.prop_telefon);
                    SQL_Befehl.Parameters.AddWithValue("@mail", teamadd.prop_email);
                    SQL_Befehl.Parameters.AddWithValue("@modemail", teamadd.prop_modemail);
                    SQL_Befehl.Parameters.AddWithValue("@wgroup", teamadd.prop_workgroup);
                    SQL_Befehl.Parameters.AddWithValue("@stext", teamadd.prop_zusatztext);
                    SQL_Befehl.Parameters.AddWithValue("@lastedit", teamadd.prop_lastmod);
                    SQL_Befehl.Parameters.AddWithValue("@tid",teamadd.prop_id);
                    try
                    {
                        SQL_Befehl.Connection.Open();
                        SQL_Befehl.ExecuteNonQuery();
                        SQL_Befehl.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Team erfoglreich bearbeitet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("Es ist ein Fehler aufgetreten, das Team konnte nicht bearbeitet werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }

            }
        }
        public static void SQL_teamdel(team teamadd)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("DELETE FROM teams where id=@tid", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@tid", teamadd.prop_id);
                    try
                    {
                        SQL_Befehl.Connection.Open();
                        SQL_Befehl.ExecuteNonQuery();
                        SQL_Befehl.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Team erfoglreich gelöscht.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("Es ist ein Fehler aufgetreten, das Team konnte nicht gelöscht werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }

            }
        }
        public static void SQL_wgadd(Workgroup wgadd)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("INSERT INTO workgroups (name) VALUES (@aname)", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@aname", wgadd.prop_name);
                    try
                    {
                        SQL_Befehl.Connection.Open();
                        SQL_Befehl.ExecuteNonQuery();
                        SQL_Befehl.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Workgroup erfoglreich angelegt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("Es ist ein Fehler aufgetreten, die Workgroup konnte nicht angelegt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }

            }
        }
        public static void SQL_wgedit(Workgroup wgedit)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("UPDATE workgroups SET name=@anzeigname WHERE ID=@wid", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@anzeigname", wgedit.prop_name);
                    SQL_Befehl.Parameters.AddWithValue("@wid", wgedit.prop_id);
                    try
                    {
                        SQL_Befehl.Connection.Open();
                        SQL_Befehl.ExecuteNonQuery();
                        SQL_Befehl.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Workgroup erfoglreich bearbeitet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("Es ist ein Fehler aufgetreten, die Workgroup konnte nicht bearbeitet werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }

            }
        }
        public static void SQL_wgdel(Workgroup wgdel)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("DELETE FROM workgroups where id=@tid", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@tid", wgdel.prop_id);
                    try
                    {
                        SQL_Befehl.Connection.Open();
                        SQL_Befehl.ExecuteNonQuery();
                        SQL_Befehl.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Workgroup erfoglreich gelöscht.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("Es ist ein Fehler aufgetreten, doe Workgroup konnte nicht gelöscht werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }

            }
        }
        public static ArrayList SQL_multipletable(string tabelle)
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT * from "+tabelle, verbindung);
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
                        liste.Add(new a_texte(rdr.GetInt32(0),rdr.GetString(1),rdr.GetString(2)));
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
        public static ArrayList SQL_req_sparepart()
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT * from sparepart", verbindung);
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
                        liste.Add(new spareparts(rdr.GetInt32(0), rdr.GetString(1),rdr.GetString(2),rdr.GetString(3)));
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
        public static string LDAP_telabfragen(string domainuser)
        {
            string rueckgabe = "";
            DirectoryEntry entry = new DirectoryEntry("LDAP://" + Environment.UserDomainName);
            MessageBox.Show("Debug Fenster: LDAP-Pfad: "+entry.Path);
            DirectorySearcher mySearcher = new DirectorySearcher(entry);
            mySearcher.Filter = "(&(ObjectClass=user)(sAMAccountName="+Environment.UserName+"))";
            mySearcher.PropertiesToLoad.Add("displayName");
            mySearcher.PropertiesToLoad.Add("telephoneNumber");
            try
            {
                SearchResult result = mySearcher.FindOne();
                if (result != null)
                {
                    DirectoryEntry result_entry = result.GetDirectoryEntry();
                    rueckgabe = "Name: " + result_entry.Properties["displayName"][0].ToString() + " Telefon Nr: " + result_entry.Properties["telephoneNumber"][0].ToString();
                    return rueckgabe;
                }
                else
                    return "Kein Treffer bei der Usersuche";
            }
            catch
            {
                return "Fehler beim Verbindungsaufbau mit LDAP";
            }
        }
    }
}
