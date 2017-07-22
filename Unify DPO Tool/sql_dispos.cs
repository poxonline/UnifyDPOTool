using System;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
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
        public static void add_dispo(dispos dispoadd)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("INSERT INTO dispos (name,email,fru,EMAIL_ASP_normal,EMAIL_ASP_eskalation,beschreibung,partner) VALUES (@name,@email,@fru,@normal,@eskalation,@beschreibung,@partner)", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@name", dispoadd.prop_name);
                    SQL_Befehl.Parameters.AddWithValue("@email", dispoadd.prop_dispomail);
                    SQL_Befehl.Parameters.AddWithValue("@fru", dispoadd.prop_fru);
                    SQL_Befehl.Parameters.AddWithValue("@normal", dispoadd.prop_email_n);
                    SQL_Befehl.Parameters.AddWithValue("@eskalation", dispoadd.prop_email_eskalation);
                    SQL_Befehl.Parameters.AddWithValue("@beschreibung", dispoadd.prop_beschreibung);
                    SQL_Befehl.Parameters.AddWithValue("@partner", dispoadd.prop_partner);

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
                    MessageBox.Show("Dispo erfoglreich angelegt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("Es ist ein Fehler aufgetreten, die Dispo konnte nicht angelegt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
        public static void update_dispo(dispos dispoadd)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("UPDATE dispos SET name=@uname,email=@uemail,fru=@ufru,EMAIL_ASP_normal=@unormal,EMAIL_ASP_eskalation=@ueskalation,beschreibung=@ubeschreibung,partner=@upartner WHERE ID=@uid", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@uid", dispoadd.prop_id);
                    SQL_Befehl.Parameters.AddWithValue("@uname", dispoadd.prop_name);
                    SQL_Befehl.Parameters.AddWithValue("@uemail", dispoadd.prop_dispomail);
                    SQL_Befehl.Parameters.AddWithValue("@ufru", dispoadd.prop_fru);
                    SQL_Befehl.Parameters.AddWithValue("@unormal", dispoadd.prop_email_n);
                    SQL_Befehl.Parameters.AddWithValue("@ueskalation", dispoadd.prop_email_eskalation);
                    SQL_Befehl.Parameters.AddWithValue("@ubeschreibung", dispoadd.prop_beschreibung);
                    SQL_Befehl.Parameters.AddWithValue("@upartner", dispoadd.prop_partner);

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
                    MessageBox.Show("Dispo erfoglreich bearbeitet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten, die Dispo konnte nicht bearbeitet werden." + Environment.NewLine + Convert.ToString(ex), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
        public static void del_dispo(dispos dispoadd)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("DELETE from dispos WHERE ID=@uid", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@uid", dispoadd.prop_id);

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
                    MessageBox.Show("Dispo erfoglreich gelöscht.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten, die Dispo konnte nicht gelöscht werden." + Environment.NewLine + Convert.ToString(ex), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
    }
}
