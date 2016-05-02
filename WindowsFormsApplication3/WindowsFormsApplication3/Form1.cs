using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCountSymbols_Click(object sender, EventArgs e)
        {
           Image[] images = new Image[6];

            Image[0] = WindowsFormsApplication3.Properties.Resources.Galge;
            Image[1] = WindowsFormsApplication3.Properties.Resources.fel1;
            Image[2] = WindowsFormsApplication3.Properties.Resources.fel2;
            Image[3] = WindowsFormsApplication3.Properties.Resources.fel3;
            Image[4] = WindowsFormsApplication3.Properties.Resources.fel4;
            Image[5] = WindowsFormsApplication3.Properties.Resources.fel5;
        }

    private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = txtBox1.TextLength.ToString();
            lblResult.Refresh();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnImageChange_Click(object sender, EventArgs e)
        {
            pctBox1.Image = WindowsFormsApplication3.Properties.Resources.Galge;
          

        }
    }
}
