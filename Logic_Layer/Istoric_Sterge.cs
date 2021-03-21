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
    class Istoric_Sterge
    {
        public static MySqlConnection conn = new MySqlConnection("Data source=localhost;userID=root;database=fertilizare");

        public static DataTable Selectez_Acvariul()
        { 
            MySqlCommand comAcvariu = new MySqlCommand();
            comAcvariu.Connection = conn;
            comAcvariu.CommandText = "SELECT ida, CONCAT(nume,' cu volum: ', CAST(volum as char(4)),' L.') AS numeac FROM acvariu ORDER BY nume";
            MySqlDataAdapter adapta = new MySqlDataAdapter(comAcvariu);
            DataTable acvariuT = new DataTable();
            try
            {
                conn.Open();
                adapta.Fill(acvariuT);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
             return acvariuT;
        }

        public static DataTable Selectez_Data(int idacvariu)
        {
            MySqlCommand cautDate = new MySqlCommand();
            cautDate.Connection = conn;
            if(idacvariu==0)
                {
                cautDate.CommandText = "SELECT DISTINCT data, iddozare FROM dozare ORDER BY data";
            }
            else
            {
                cautDate.CommandText = "SELECT DISTINCT data FROM dozare WHERE idacv = @idacvariu ORDER BY data";
                cautDate.Parameters.AddWithValue("@idacvariu", idacvariu);
            }
            MySqlDataAdapter dataadapt = new MySqlDataAdapter(cautDate);
            DataTable dataT = new DataTable();
            try
            {
                conn.Open();
                dataadapt.Fill(dataT);
                cautDate.Parameters.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dataT;
        }
        public static DataTable Selectez_Dozari(int idacvariu, DateTime data)
        {
            MySqlCommand cautDozari = new MySqlCommand();
            cautDozari.Connection = conn;
            cautDozari.CommandText = "SELECT iddozare, CONCAT( d.data,' a fost adaugat ', d.cantitate,' lingurite ',s.nume, ' in acvariul ',a.nume,'.') as date FROM dozare d JOIN substante s ON idsub=ids JOIN acvariu a ON idacv=ida WHERE idacv = @idacvariu AND data = @data ORDER BY data"; 
            cautDozari.Parameters.AddWithValue("@idacvariu", idacvariu);
            cautDozari.Parameters.AddWithValue("@data", data);
            MySqlDataAdapter adaptDoze = new MySqlDataAdapter(cautDozari);
            DataTable dozeDT = new DataTable();
            try
            {
                conn.Open();
                adaptDoze.Fill(dozeDT);
                cautDozari.Parameters.Clear();
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dozeDT;
        }
        public static void Sterge_Inregistrari(ArrayList DozariInutile, DateTime t, int id_acvariu)
        {
            MySqlCommand stergInregistrare = new MySqlCommand("Delete from dozare where iddozare=@iddozare and data=@data and idacv = @id_acvariu", conn);
            conn.Open();
            MySqlTransaction tx = conn.BeginTransaction();
            try
            {
                stergInregistrare.Transaction = tx;
                foreach (int id_doza in DozariInutile)
                {
                    stergInregistrare.Parameters.AddWithValue("@iddozare", id_doza);
                    stergInregistrare.Parameters.AddWithValue("@data", t);
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
    }
}
