using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using fertilizare.Logic_Layer;

namespace fertilizare.Data_acces_Layer
{
    public partial class AdaugaDozare : Form
    {
        DataTable acvariuT = new DataTable();
        DataTable substanteT = new DataTable();
        public AdaugaDozare()
        {
            InitializeComponent();
            Completez_Combo_Acvariu();
            Completez_Combo_Substante();
        }
        void Completez_Combo_Acvariu()
        {

            acvariuT = Dozare.Selectez_Acvariul();
            comboBoxAcvariu.Items.Clear();
            comboBoxAcvariu.DataSource = acvariuT;
            comboBoxAcvariu.ValueMember = "ida";
            comboBoxAcvariu.DisplayMember = "numeac";
        }
        void Completez_Combo_Substante()
        {

            substanteT = Dozare.Selectez_Substante();
            comboBoxSubstanta.Items.Clear();
            comboBoxSubstanta.DataSource = substanteT;
            comboBoxSubstanta.ValueMember = "ids";
            comboBoxSubstanta.DisplayMember = "substanta";

        }

        private void buttonInchide_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void buttonInregistreaza_Click(object sender, EventArgs e)
        {
            DataRowView drvacvariu = comboBoxAcvariu.SelectedItem as DataRowView;
            DataRowView drvsubstanta = comboBoxSubstanta.SelectedItem as DataRowView;
            string mesaj = "Ati adaugat " + textBoxCantitate.Text + " lingurite\n" + drvsubstanta["substanta"]+"\nin acvariul" + drvacvariu["numeac"] + "?";
            Confirmare c = new Confirmare(mesaj);
            DialogResult dr = c.ShowDialog();
            if (dr == DialogResult.Yes)
                try
                {
                    int ida = Convert.ToInt32(comboBoxAcvariu.SelectedValue);
                    int ids = Convert.ToInt32(comboBoxSubstanta.SelectedValue);
                    string cantitate = Convert.ToString(textBoxCantitate.Text);
                    Dozare.Inregistrez_Dozare(ids, ida, dateTimePicker1.Value.Date, cantitate);
                    substanteT.Clear();
                    comboBoxSubstanta.DataSource = null;
                    Completez_Combo_Substante();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            if (dr == DialogResult.No)
            {
                MessageBox.Show("Nu s-a inregistrat nici o dozare");
            }
        }
    }
}
