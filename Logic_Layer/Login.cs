using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace fertilizare.Logic_Layer
{
    class Login
    {
        public static string caut_User_Parola(string u, string p)
        {
            string connstr = "Data Source=localhost;UserId=root;database=fertilizare";
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();
            MySqlCommand comUser = new MySqlCommand("SELECT nume_rol FROM user join rol on idrol=idr where user= @utilizator and parola= @parola", conn);
            comUser.Parameters.AddWithValue("@utilizator", u);
            comUser.Parameters.AddWithValue("@parola", p);
            MySqlDataReader readerUser = comUser.ExecuteReader();
            string rol = "";

            if (readerUser.Read())
            {
                rol = readerUser["nume_rol"].ToString();
            }

            conn.Close();
            return rol;
        }
    }
}
