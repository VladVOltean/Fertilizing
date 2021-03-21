using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  
using System.Data;
using System.Collections;

namespace fertilizare.Logic_Layer
{
    class Adau_Sterg_date
    {
        static MySqlConnection conn = new MySqlConnection("DataSource=localhost; UserID=root;database=fertilizare");
        public static void Adauga_Acvariu(string numeacvariu, int volum)
        {
            conn.Open();
            MySqlCommand adaugAcvariu = new MySqlCommand("INSERT INTO acvariu (nume, volum) VALUES(@numea, @volum);", conn);
            adaugAcvariu.Parameters.AddWithValue("@numea", numeacvariu);
            adaugAcvariu.Parameters.AddWithValue("@volum", volum);
            adaugAcvariu.ExecuteNonQuery();
            conn.Close();
        }

        public static void Adauga_Substanta(string numesubstanta, string denumires)
        {
            conn.Open();
            MySqlCommand adaugSubstanta = new MySqlCommand("INSERT INTO substante (nume, denumire) VALUES(@numes, @denumires);", conn);
            adaugSubstanta.Parameters.AddWithValue("@numes", numesubstanta);
            adaugSubstanta.Parameters.AddWithValue("@denumires", denumires);
            adaugSubstanta.ExecuteNonQuery();
            conn.Close();
        }
        public static void Adauga_Utilizator(string user, string parola, string nume_pre)
        {
            conn.Open();
            MySqlCommand adaugSubstanta = new MySqlCommand("INSERT INTO user (pre_nume,user, parola, idrol) VALUES(@nume_pre, @user, @parola, @idrol);", conn);
            adaugSubstanta.Parameters.AddWithValue("@nume_pre",nume_pre );
            adaugSubstanta.Parameters.AddWithValue("@user", user);
            adaugSubstanta.Parameters.AddWithValue("@parola", parola);
            adaugSubstanta.Parameters.AddWithValue("@idrol", 2);
            adaugSubstanta.ExecuteNonQuery();
            conn.Close();
        }
        public static void Sterge_Acvarii( ArrayList acvariisterse)
        {
            MySqlCommand stergInregistrare = new MySqlCommand("Delete from acvariu where ida=@id_acvariu", conn);
            conn.Open();
            MySqlTransaction tx = conn.BeginTransaction();
            try
            { 
                stergInregistrare.Transaction = tx;
                foreach (int id_acvariu in acvariisterse)
                {
                    stergInregistrare.Parameters.AddWithValue("@id_acvariu", id_acvariu);
                    stergInregistrare.ExecuteNonQuery();
                    stergInregistrare.Parameters.Clear();
                }
                tx.Commit();
            }
            catch (Exception)
            {
                tx.Rollback();
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void Sterge_Substante (ArrayList substantesterse)
        {
            MySqlCommand stergInregistrare = new MySqlCommand("Delete from substante where ids=@id_substanta", conn);
            conn.Open();
            MySqlTransaction tx = conn.BeginTransaction();
            try
            {
                stergInregistrare.Transaction = tx;
                foreach (int id_substanta in substantesterse)
                {
                    stergInregistrare.Parameters.AddWithValue("@id_substanta", id_substanta);
                    stergInregistrare.ExecuteNonQuery();
                    stergInregistrare.Parameters.Clear();
                }
                tx.Commit();
            }
            catch (Exception)
            {
                tx.Rollback();
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
    
}
