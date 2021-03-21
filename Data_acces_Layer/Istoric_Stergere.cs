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
    public partial class Istoric_Stergere : Form
    {
        int idacvariu;
        DateTime d;
        DataTable acvariuT = new DataTable();
        DataTable dataT = new DataTable();
        DataTable dozariT = new DataTable();
        DataRow acvariuR;
        public Istoric_Stergere(string tipinterogare)
        {
            InitializeComponent();
            Completez_Combo_Acvariu();
            Completez_Combo_Date(idacvariu);
            listBoxDozari.Hide();
            checkedListBoxDozare.Hide();
            if (tipinterogare == "Istoric")
                arata_istoric();
            else
                sterge_date();

        }
        public void arata_istoric()
        {
            listBoxDozari.Visible = true;
            listBoxDozari.Location = new System.Drawing.Point(90, 230);
            listBoxDozari.Size = new System.Drawing.Size(700, 220);
            comboBoxData.SelectionChangeCommitted += new System.EventHandler(comboBoxData_SelectionChangeCommitted);
            buttonSterge.Hide();
            buttonRenunta.Hide();
            buttonIesire.Location = new System.Drawing.Point(340, 490);

        }
        public void sterge_date()
        {
            checkedListBoxDozare.Visible = true;
            checkedListBoxDozare.Location = new System.Drawing.Point(90, 230);
            checkedListBoxDozare.Size = new System.Drawing.Size(700, 220);
        }
        public void Completez_Combo_Acvariu()
        {
            comboBoxAcvariu.Items.Clear();
            acvariuT = Istoric_Sterge.Selectez_Acvariul();
            acvariuR = acvariuT.NewRow();
            acvariuR["ida"] = "0";
            acvariuR["numeac"] = "--Toate acvariile-";
            acvariuT.Rows.InsertAt(acvariuR, 0);
            comboBoxAcvariu.DataSource = acvariuT;
            comboBoxAcvariu.ValueMember = "ida";
            comboBoxAcvariu.DisplayMember = "numeac";
        }
        public void Completez_Combo_Date(int idacvariu)
        {

            dataT = Istoric_Sterge.Selectez_Data(idacvariu);
            comboBoxData.DataSource = dataT;
            comboBoxData.ValueMember = "iddozare";
            comboBoxData.DisplayMember = "data";

        }
        private void comboBoxAcvariu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                    idacvariu = Convert.ToInt32(comboBoxAcvariu.SelectedValue.ToString());
                    dataT.Clear();
                    comboBoxData.DataSource = null;
                    Completez_Combo_Date(idacvariu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxData_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DateTime d = Convert.ToDateTime(comboBoxData.SelectedText);
                dozariT.Clear();
                listBoxDozari.DataSource = null;
                checkedListBoxDozare.DataSource = null;
                Completez_ListBox_Dozari(idacvariu, d);
                Completez_CheckedListBox_Dozari(idacvariu, d);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Completez_ListBox_Dozari(int idacvariu, DateTime d)
        {
            dozariT = Istoric_Sterge.Selectez_Dozari(idacvariu, d);
            listBoxDozari.Items.Clear();
            listBoxDozari.DataSource = dozariT;
            listBoxDozari.ValueMember = "iddozare";
            listBoxDozari.DisplayMember = "date";
        }
 
        public void Completez_CheckedListBox_Dozari(int idacvariu, DateTime d)
        {
            dozariT = Istoric_Sterge.Selectez_Dozari(idacvariu, d);
            checkedListBoxDozare.Items.Clear();
            checkedListBoxDozare.DataSource = dozariT;
            checkedListBoxDozare.ValueMember = "iddozare";
            checkedListBoxDozare.DisplayMember = "date";

        }


        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if (checkedListBoxDozare.CheckedIndices.Count > 0)
            {
                Confirmare c = new Confirmare("Confirmati stergerea datelor?");
                DialogResult dr = c.ShowDialog();
                ArrayList DozariInutile = new ArrayList();
                if (dr == DialogResult.Yes)
                {
                    int id_doza;
                    try
                    {
                        foreach (int i in checkedListBoxDozare.CheckedIndices)
                        {
                            checkedListBoxDozare.SelectedIndex = i;
                            id_doza = Convert.ToInt32(checkedListBoxDozare.SelectedValue);
                            DozariInutile.Add(id_doza);
                        }
                        Istoric_Sterge.Sterge_Inregistrari(DozariInutile, d, idacvariu);
                        MessageBox.Show("Stergere s-a efectuat cu succes");
                        dozariT.Clear();
                        checkedListBoxDozare.DataSource = null;
                        Completez_CheckedListBox_Dozari(idacvariu, d);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Restituirea NU a fost inregistrata");
                    Goleste_checkedListBoxDozare();
                }
            }
            else MessageBox.Show("NU ati selectat nici o inregistrare");
        }
        private void Goleste_checkedListBoxDozare()
        {
            checkedListBoxDozare.ClearSelected();
            foreach (int i in checkedListBoxDozare.CheckedIndices)
                checkedListBoxDozare.SetItemChecked(i, false);
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            Goleste_checkedListBoxDozare();
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAfiseaza_Click(object sender, EventArgs e)
        {
            try
            {
                d = Convert.ToDateTime(comboBoxData.SelectedValue.ToString());
                dozariT.Clear();
                listBoxDozari.DataSource = null;
                checkedListBoxDozare.DataSource = null;
                Completez_ListBox_Dozari(idacvariu, d);
                Completez_CheckedListBox_Dozari(idacvariu, d);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
