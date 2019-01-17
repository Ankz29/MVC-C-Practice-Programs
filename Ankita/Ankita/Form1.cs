using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ankita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label3.BackColor = label1.BackColor;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label3.BackColor = label2.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
