using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fertilizare.Data_acces_Layer
{
    public partial class EditeazaDozari : Form
    {
        static MySqlConnection conn = new MySqlConnection("DataSource=localhost; UserID=root; database = fertilizare");
        MySqlDataAdapter adapgrid;
        DataTable dozareDT = new DataTable();
        MySqlCommandBuilder cb;

        public EditeazaDozari()
        {
            InitializeComponent();
        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adapgrid = new MySqlDataAdapter("SELECT*FROM dozare", conn);
                dozareDT.Clear();
                adapgrid.Fill(dozareDT);
                dataGridViewDozari.DataSource = dozareDT;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonEditare_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cb = new MySqlCommandBuilder(adapgrid);
                adapgrid.Update(dozareDT);
                MessageBox.Show("Am modificat tabelul Dozari");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
