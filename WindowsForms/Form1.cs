using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class BackGroung : Form
    {
        public BackGroung()
        {
            InitializeComponent();
        }

        private void class11_CheckedChanged(object sender, EventArgs e)
        {
            if(class11.Checked)
            {
                this.BackColor = Color.DimGray;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }
        }
    }
}
