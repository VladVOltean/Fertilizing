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
using fertilizare.Data_acces_Layer;

namespace fertilizare
{
    public partial class Form1 : Form
    {
        int login;
        string userTastat, parolaTastata, user_role;
        public Form1()
        {
            InitializeComponent();
            ascundeMeniuTot();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adaugaDozareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaDozare adaug = new AdaugaDozare();
            adaug.ShowDialog();
        }

        private void istoricStripMenuItem_Click(object sender, EventArgs e)
        {
            Istoric_Stergere lista = new Istoric_Stergere("Istoric");
            lista.ShowDialog();
        }

        private void stergeDozareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Istoric_Stergere lista = new Istoric_Stergere("Stergere");
            lista.ShowDialog();
        }

        private void acvariuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaDate adaug = new AdaugaDate("Acvariu");
            adaug.ShowDialog();
        }

        private void substantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaDate adaug = new AdaugaDate("Substanta");
            adaug.ShowDialog();
        }

        private void editeazaDozareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditeazaDozari edit = new EditeazaDozari();
            edit.ShowDialog();
        }

        private void stergereAcvariuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergeDate sterg = new StergeDate("Acvariu");
            sterg.ShowDialog();
        }

        private void stergereSubstanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergeDate sterg = new StergeDate("Substanta");
            sterg.ShowDialog();
        }

        private void adaugaUtilizatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaDate adaug = new AdaugaDate("Utilizator");
            adaug.ShowDialog();
        }

        private void ascundeMeniuTot()
        {
            adaugaToolStripMenuItem.Visible = false;
            dozariToolStripMenuItem.Visible = false;
            editeazaDozareToolStripMenuItem.Visible = false;
            button1.Text = "Log in";
            login = 0;
            userTastat = parolaTastata = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (login == 0)
                {
                    userTastat = textBoxUser.Text.Trim();
                    parolaTastata = textBoxParola.Text;
                    if (userTastat == "") throw new Exception("Completati campul User");
                    if (parolaTastata == "") throw new Exception("Completati campul Parola");
                    user_role = Login.caut_User_Parola(userTastat, parolaTastata);
                    labelTest.Text = user_role;
                    if (user_role == "Admin")
                    { 
                        login = 1;
                        adaugaToolStripMenuItem.Visible = true;
                        dozariToolStripMenuItem.Visible = true;
                        editeazaDozareToolStripMenuItem.Visible = true;
                        stergeDozareToolStripMenuItem.Visible = true;
                        button1.Text = "Log out";
                    }
                    if (user_role == "Utilizator")
                    { 
                        login = 2;
                        dozariToolStripMenuItem.Visible = true;
                        stergeDozareToolStripMenuItem.Visible = false;
                        button1.Text = "Log out";
                    }
                    if (login == 0)
                        throw new Exception("User sau Parola incorecte");
                }
                else
                {
                    textBoxUser.Text = "";
                    textBoxParola.Text = "";
                    ascundeMeniuTot();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
