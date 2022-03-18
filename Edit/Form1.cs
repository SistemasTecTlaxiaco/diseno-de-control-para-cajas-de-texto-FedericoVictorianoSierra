using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButton1.Checked)//Tema Blanco
            {
                BackGroundBuscador.BackColor = Color.FromArgb(241, 243, 248);
                Tab1.BackColor = Color.FromArgb(241, 243, 248);
                DoodleText.ForeColor = Color.FromArgb(57, 59, 68);

            }
            else //Tema Negro
            {
                BackGroundBuscador.BackColor = Color.FromArgb(58, 60, 69);
                Tab1.BackColor = Color.FromArgb(58, 60, 69);
                DoodleText.ForeColor = Color.FromArgb(241, 243, 248);
            }
        }
    }
}
