using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace fertilizare.Logic_Layer
{
    class Dozare
    {
        static MySqlConnection conn = new MySqlConnection("Data source=localhost;userID=root;database=fertilizare");

        public static DataTable Selectez_Acvariul()
        {
            conn.Open();
            MySqlCommand comAcvariu = new MySqlCommand("SELECT ida, CONCAT(nume,' Volum:', CAST(volum as char(4)),' L') AS numeac FROM acvariu ORDER BY nume", conn);
            MySqlDataAdapter adapta = new MySqlDataAdapter(comAcvariu);
            DataTable acvariuT = new DataTable();
            adapta.Fill(acvariuT);
            conn.Close();
            return acvariuT;
        }

        public static DataTable Selectez_Substante()
        {
            conn.Open();
            MySqlCommand comSubstante = new MySqlCommand("SELECT ids, CONCAT(nume, '  ', denumire) as substanta FROM substante order by nume", conn);
            MySqlDataAdapter adapts = new MySqlDataAdapter(comSubstante);
            DataTable substanteT = new DataTable();
            adapts.Fill(substanteT);
            conn.Close();
            return substanteT;
        }

        public static void Inregistrez_Dozare(int ids, int ida, DateTime dataDozare, string cantitate)
        {
            conn.Open();
            MySqlCommand adaugDoza = new MySqlCommand("INSERT INTO dozare (idsub, idacv, data, cantitate) VALUES (@idsub,@idacv, CAST(@data as datetime), @cantitate)", conn);
            MySqlTransaction tx = conn.BeginTransaction();
            try
            {
          
                adaugDoza.Transaction = tx;
                adaugDoza.Parameters.AddWithValue("@idsub", ids);
                adaugDoza.Parameters.AddWithValue("@idacv", ida);
                adaugDoza.Parameters.AddWithValue("@data", dataDozare);
                adaugDoza.Parameters.AddWithValue("@cantitate", cantitate);
                adaugDoza.ExecuteNonQuery();
                adaugDoza.Parameters.Clear();
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
