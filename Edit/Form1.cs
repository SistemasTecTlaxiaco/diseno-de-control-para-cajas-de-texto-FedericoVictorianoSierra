using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
                Tab2.BackColor = Color.FromArgb(235, 238, 246);
                DoodleText.ForeColor = Color.FromArgb(57, 59, 68);

            }
            else //Tema Negro
            {
                BackGroundBuscador.BackColor = Color.FromArgb(58, 60, 69);
                Tab1.BackColor = Color.FromArgb(58, 60, 69);
                Tab2.BackColor = Color.FromArgb(95, 99, 110);
                DoodleText.ForeColor = Color.FromArgb(241, 243, 248);
            }
        }

        private void rjButton11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rjButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            maximizar.Visible = false;
            minimizar.Visible = true;
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rjButton14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            minimizar.Visible = false;
            maximizar.Visible = true;
        }
    }
}
