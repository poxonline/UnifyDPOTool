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
        public static ArrayList select_dispos_intern()
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT * from dispos where partner=0;", verbindung);
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
        public static ArrayList select_dispos_extern()
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT * from dispos where partner=1;", verbindung);
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
        public static ArrayList select_dispos_with_asp(asp abfrage)
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT dispo from hilf_dispo where asp=@uname", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@uname", abfrage.prop_name);
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
                        liste.Add(rdr.GetString(0));
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
        public static string select_aspmails_with_dispo(dispos abfrage)
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT asp from hilf_dispo where dispo=@udispo", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@udispo", abfrage.prop_name);
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
                        liste.Add(rdr.GetString(0));
                    }
                    rdr.Close();
                    verbindung.Close();
                    string mails="";
                    foreach (string element in liste)
                    {
                        MySqlCommand SQL_Befehl_mails = new MySqlCommand("SELECT email from asp where name=@uname", verbindung);
                        SQL_Befehl_mails.Parameters.AddWithValue("@uname", element);
                        try
                        {
                            verbindung.Open();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        rdr = SQL_Befehl_mails.ExecuteReader();
                        while (rdr.Read())
                        {
                            mails+=";"+(rdr.GetString(0));
                        }
                        rdr.Close();
                        verbindung.Close();
                    }
                    return mails;
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
        public static ArrayList select_asps_with_dispo(dispos abfrage)
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    ArrayList rueckgabe = new ArrayList();
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT asp from hilf_dispo where dispo=@udispo", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@udispo", abfrage.prop_name);
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
                        liste.Add(rdr.GetString(0));
                    }
                    rdr.Close();
                    verbindung.Close();
                    foreach (string element in liste)
                    {
                        MySqlCommand SQL_Befehl_mails = new MySqlCommand("SELECT * from asp where name=@uname", verbindung);
                        SQL_Befehl_mails.Parameters.AddWithValue("@uname", element);
                        try
                        {
                            verbindung.Open();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        rdr = SQL_Befehl_mails.ExecuteReader();
                        while (rdr.Read())
                        {
                            rueckgabe.Add(new asp(rdr.GetInt32(0),rdr.GetString(1),rdr.GetString(2),rdr.GetString(3)));
                        }
                        rdr.Close();
                        verbindung.Close();
                    }
                    return rueckgabe;
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
        public static ArrayList select_dispo_tel()
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT * from dispos_tel;", verbindung);
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
                        liste.Add(new dispos_tel(rdr.GetInt32(0),rdr.GetString(1),rdr.GetString(2),rdr.GetString(3)));
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
        public static void add_disp_tel(dispos_tel dispotel_obj)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("INSERT INTO dispos_tel (beschreibung,tel,dispo) VALUES (@ubeschreibung,@utel,@udispo)", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@ubeschreibung", dispotel_obj.prop_beschreibung);
                    SQL_Befehl.Parameters.AddWithValue("@utel",dispotel_obj.prop_tel );
                    SQL_Befehl.Parameters.AddWithValue("@udispo",dispotel_obj.prop_dispo );

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
                    MessageBox.Show("Rufnummer erfoglreich angelegt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    MessageBox.Show("Es ist ein Fehler aufgetreten, die Rufnummer konnte nicht angelegt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
        public static void update_dispo_tel(dispos_tel dispotel_obj)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("UPDATE dispos_tel SET beschreibung=@ubeschreibung,tel=@utel,dispo=@udispo WHERE ID=@uid", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@uid", dispotel_obj.prop_id);
                    SQL_Befehl.Parameters.AddWithValue("@ubeschreibung", dispotel_obj.prop_beschreibung);
                    SQL_Befehl.Parameters.AddWithValue("@utel", dispotel_obj.prop_tel);
                    SQL_Befehl.Parameters.AddWithValue("@udispo", dispotel_obj.prop_dispo);

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
                    MessageBox.Show("Rufnummer erfoglreich bearbeitet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten, die Rufnummer konnte nicht bearbeitet werden." + Environment.NewLine + Convert.ToString(ex), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
        public static void del_dispo_tel(dispos_tel dispotel_obj)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("DELETE from dispos_tel WHERE ID=@uid", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@uid", dispotel_obj.prop_id);

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
                    MessageBox.Show("Rufnummer erfoglreich gelöscht.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten, die Rufnummer konnte nicht gelöscht werden." + Environment.NewLine + Convert.ToString(ex), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
        public static void add_dispo_asp(asp asp_neu)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("INSERT INTO asp (name, email, tel) VALUES (@uname,@uemail,@utel)", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@uname", asp_neu.prop_name);
                    SQL_Befehl.Parameters.AddWithValue("@uemail", asp_neu.prop_mail);
                    SQL_Befehl.Parameters.AddWithValue("@utel", asp_neu.prop_tel);

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
                    MessageBox.Show("Ansprechpartner wurde erfolgreich angelegt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten, der Ansprechpartner konnte nicht angelegt werden." + Environment.NewLine + Convert.ToString(ex), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
        public static void add_hilf_dispo(asp asp_neu, ArrayList zuordnung)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                foreach(dispos element in zuordnung)
                {
                    try
                    {
                        verbindung.ConnectionString = connection;
                        MySqlCommand SQL_Befehl = new MySqlCommand("INSERT INTO hilf_dispo (dispo,asp) VALUES (@udispo,@uasp)", verbindung);
                        SQL_Befehl.Parameters.AddWithValue("@udispo", element.prop_name);
                        SQL_Befehl.Parameters.AddWithValue("@uasp", asp_neu.prop_name);

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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Es ist ein Fehler aufgetreten, der Ansprechpartner konnte der Dispo nicht zugeordnet werden." + Environment.NewLine + Convert.ToString(ex), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                    }
                }
            }
        }
        public static void del_hilf_dispo(asp asp_neu)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("DELETE from hilf_dispo where asp=@uname", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@uname", asp_neu.prop_name);

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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten, dem Ansprechpartner konnte die Dispo nicht entfernt werden." + Environment.NewLine + Convert.ToString(ex), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
        public static ArrayList select_asp()
        {
            MySqlDataReader rdr = null;
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("SELECT * from asp;", verbindung);
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
                        liste.Add(new asp(rdr.GetInt32(0),rdr.GetString(1),rdr.GetString(2),rdr.GetString(3)));
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
        public static void update_asp(asp asp_edit)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("UPDATE asp SET name=@uname,email=@umail,tel=@utel WHERE ID=@uid", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@uid", asp_edit.prop_id);
                    SQL_Befehl.Parameters.AddWithValue("@uname", asp_edit.prop_name);
                    SQL_Befehl.Parameters.AddWithValue("@umail", asp_edit.prop_mail);
                    SQL_Befehl.Parameters.AddWithValue("@utel", asp_edit.prop_tel);

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
                    MessageBox.Show("Ansprechpartner erfoglreich bearbeitet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten, der Ansprechpartner konnte nicht bearbeitet werden." + Environment.NewLine + Convert.ToString(ex), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
        public static void del_asp(asp asp_edit)
        {
            using (MySqlConnection verbindung = new MySqlConnection())
            {
                try
                {
                    verbindung.ConnectionString = connection;
                    MySqlCommand SQL_Befehl = new MySqlCommand("DELETE FROM asp WHERE ID=@uid", verbindung);
                    SQL_Befehl.Parameters.AddWithValue("@uid", asp_edit.prop_id);

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
                    MessageBox.Show("Ansprechpartner erfoglreich gelöscht.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten, der Ansprechpartner konnte nicht gelöscht werden." + Environment.NewLine + Convert.ToString(ex), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
    }
}
