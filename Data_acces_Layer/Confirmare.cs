using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fertilizare.Data_acces_Layer
{
    public partial class Confirmare : Form
    {
        public Confirmare(string mesaj)
        {
            InitializeComponent();
            labelConfirmare.Text = mesaj;
        }
    }
}
