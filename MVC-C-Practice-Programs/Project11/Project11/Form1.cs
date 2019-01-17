using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label5.BackColor = label1.BackColor;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label5.BackColor = label2.BackColor;
        }

        /*private void label3_Click(object sender, EventArgs e)
        {
            label5.BackColor = label3.BackColor;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label5.BackColor = label4.BackColor;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label6.BackColor = label5.BackColor;
        }*/

    }
}
