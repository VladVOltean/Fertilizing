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
    public partial class StergeDate : Form
    {
        DataTable acvariuT = new DataTable();
        DataTable substanteT = new DataTable();
        public StergeDate( string tipdate)
        {
            InitializeComponent();
            if(tipdate=="Acvariu")
            {
                Completez_CheckedBox_Acvarii();
                labelDate.Text = "Selecteaza acvariul";
            }
            else
            {
                Completez_CheckedBox_Substante();
                labelDate.Text = "Selecteaza substanta";

            }
        }
        public void Completez_CheckedBox_Acvarii()
        {
            acvariuT = Dozare.Selectez_Acvariul();
            checkedListBox1.Items.Clear();
            checkedListBox1.DataSource = acvariuT;
            checkedListBox1.ValueMember = "ida";
            checkedListBox1.DisplayMember = "numeac";
        }
        public void Completez_CheckedBox_Substante()
        {
            substanteT = Dozare.Selectez_Substante();
            checkedListBox1.Items.Clear();
            checkedListBox1.DataSource = substanteT;
            checkedListBox1.ValueMember = "ids";
            checkedListBox1.DisplayMember = "substanta";
        }
        private void Goleste_checkedListBox()
        {
            checkedListBox1.ClearSelected();
            foreach (int i in checkedListBox1.CheckedIndices)
                checkedListBox1.SetItemChecked(i, false);
        }
        public void Sterge_acvarii()
        {
            if (checkedListBox1.CheckedIndices.Count > 0)
            {
                Confirmare c = new Confirmare("Stergeti acvariul?");
                DialogResult dr = c.ShowDialog();
                ArrayList Acvariisterse = new ArrayList();
                if (dr == DialogResult.Yes)
                {
                    int id_acvariu;
                    try
                    {
                        foreach (int i in checkedListBox1.CheckedIndices)
                        {
                            checkedListBox1.SelectedIndex = i;
                            id_acvariu= Convert.ToInt32(checkedListBox1.SelectedValue);
                            Acvariisterse.Add(id_acvariu);
                        }
                        Adau_Sterg_date.Sterge_Acvarii(Acvariisterse);
                        MessageBox.Show("Acvariul a fost sters din Baza de date");
                        acvariuT.Clear();
                        checkedListBox1.DataSource = null;
                        Completez_CheckedBox_Acvarii();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Stergerea nu a fost efectuata");
                    Goleste_checkedListBox();
                }
            }
            else MessageBox.Show("Nu ati selectat nici un acvariu");
        }

        public void Sterge_substante()
        {
            if (checkedListBox1.CheckedIndices.Count > 0)
            {
                Confirmare c = new Confirmare("Stergeti substanta?");
                DialogResult dr = c.ShowDialog();
                ArrayList Substantesterse = new ArrayList();
                if (dr == DialogResult.Yes)
                {
                    int id_substanta;
                    try
                    {
                        foreach (int i in checkedListBox1.CheckedIndices)
                        {
                            checkedListBox1.SelectedIndex = i;
                            id_substanta = Convert.ToInt32(checkedListBox1.SelectedValue);
                            Substantesterse.Add(id_substanta);
                        }
                        Adau_Sterg_date.Sterge_Substante(Substantesterse);
                        MessageBox.Show("Substanta a fost stearsa din Baza de date");
                        acvariuT.Clear();
                        checkedListBox1.DataSource = null;
                        Completez_CheckedBox_Substante();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Stergerea nu a fost efectuata");
                    Goleste_checkedListBox();
                }
            }
            else MessageBox.Show("Nu ati selectat nici un acvariu");

        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if (labelDate.Text == "Selecteaza acvariul")
                Sterge_acvarii();
            else
                Sterge_substante();
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            Goleste_checkedListBox();
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
