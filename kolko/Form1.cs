using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color color1;
        Color color2;
       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 arg = new Form2();
            arg.Name1_value.Text = textBox1.Text;
            arg.Name2_value.Text = textBox2.Text;
            arg.panel1.BackColor = color1;
            arg.panel2.BackColor = color2;
            arg.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color1 = colorDialog1.Color;
                textBox3.BackColor= color1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                color2 = colorDialog2.Color;
                textBox4.BackColor = color2;
            }
        }
    }
}
