using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using fertilizare.Logic_Layer;

namespace fertilizare.Data_acces_Layer
{
    public partial class AdaugaDate : Form
    {
        string numeacv, numesub, denumire,user, parola, nume_pre;
        int volum;
        public AdaugaDate(string tipAdaugare)
        {
            InitializeComponent();
            if (tipAdaugare == "Acvariu")
                ascunde_Obiecte_Substante();
            else if (tipAdaugare == "Substanta")
            {
                ascunde_Obiecte_Acvariu();
            }
            else
                ascunde_Obiecte_Utilizator();
         }
        private void ascunde_Obiecte_Substante()
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            textBoxNumeS.Hide();
            textBoxDenumire.Hide();
            textBoxUser.Hide();
            textBoxParola.Hide();
            textBoxNumePrenume.Hide();
            buttonRenunta.Location = new System.Drawing.Point(280, 90);
            buttonAdauga.Location = new System.Drawing.Point(60, 90);
            buttonAdauga.Text = "Adauga acvariu";
            buttonAdauga.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(410, 130);
        }
        private void ascunde_Obiecte_Utilizator()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            textBoxNumeS.Hide();
            textBoxDenumire.Hide();
            textBoxNumeA.Hide();
            textBoxVolum.Hide();
            label7.Location = new System.Drawing.Point(30, 80);
            label5.Location = new System.Drawing.Point(30, 20);
            label6.Location = new System.Drawing.Point(30, 50);
            textBoxUser.Location = new System.Drawing.Point(210, 15);
            textBoxParola.Location = new System.Drawing.Point(210, 45);
            textBoxNumePrenume.Location = new System.Drawing.Point(210, 75);
            buttonRenunta.Location = new System.Drawing.Point(280, 110);
            buttonAdauga.Location = new System.Drawing.Point(60, 110);
            buttonAdauga.Text = "Adauga utilizator";
            buttonAdauga.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(410, 150);
        }
        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            textBoxNumeA.Text = "";
            textBoxVolum.Text = "";
            textBoxNumeS.Text = "";
            textBoxDenumire.Text = "";
            textBoxUser.Text = "";
            textBoxParola.Text = "";
        }

        private void ascunde_Obiecte_Acvariu()
        {
            label1.Hide();
            label2.Hide();
            textBoxNumeA.Hide();
            textBoxVolum.Hide();
            label3.Location = new System.Drawing.Point(30, 20);
            label4.Location = new System.Drawing.Point(30, 50);
            textBoxNumeS.Location = new System.Drawing.Point(200, 15);
            textBoxDenumire.Location = new System.Drawing.Point(200, 45);
            buttonRenunta.Location = new System.Drawing.Point(275, 90);
            buttonAdauga.Location = new System.Drawing.Point(50, 90);
            buttonAdauga.Text = "Adauga substanta";
            buttonAdauga.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(410, 130);
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if (buttonAdauga.Text == "Adauga acvariu")
            {
                numeacv = textBoxNumeA.Text;
                volum = Convert.ToInt32(textBoxVolum.Text);
                try
                {
                    if (numeacv == "") throw new Exception("Completati numele acvariului");
                    if (volum == 0) throw new Exception("Completati volumul acvariului");
                    Adau_Sterg_date.Adauga_Acvariu(numeacv,volum);
                    MessageBox.Show("Am adaugat "+numeacv+" in baza de date");
                    textBoxNumeA.Text = "";
                    textBoxVolum.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(buttonAdauga.Text=="Adauga substanta")
            {
                numesub = textBoxNumeS.Text;
                denumire = textBoxDenumire.Text;
                try
                {
                    if (numesub == "") throw new Exception("Completati formula substantei");
                    if (denumire == "") throw new Exception("Completati denumirea substantei");
                    Adau_Sterg_date.Adauga_Substanta(numesub, denumire);
                    MessageBox.Show("Am adaugat "+denumire+" in baza de date");
                    textBoxDenumire.Text = "";
                    textBoxNumeS.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                user = textBoxUser.Text;
                parola = textBoxParola.Text;
                nume_pre = textBoxNumePrenume.Text;
                try
                {
                    if (user == "") throw new Exception("Completati numele userului");
                    if (parola == "") throw new Exception("Introduceti parola");
                    if (nume_pre == "") throw new Exception("Completati numele utilizatorului");
                    Adau_Sterg_date.Adauga_Utilizator(user, parola, nume_pre);
                    MessageBox.Show("Utilizatorul "+nume_pre+" a fost adaugat in Baza de date");
                    textBoxDenumire.Text = "";
                    textBoxNumeS.Text = "";
                    textBoxNumePrenume.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
