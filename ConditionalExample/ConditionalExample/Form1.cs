using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConditionalExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mohin")
            {
                MessageBox.Show("Hay Gayes");
            }
            else if (comboBox1.Text == "Joy")
            {

                MessageBox.Show("Sabbir");
            }
            else if (comboBox1.Text=="Eather")
            {
                MessageBox.Show("YO YO YO");
            }
            else
            {
                MessageBox.Show("No Time");
            }
        }
    }
}
