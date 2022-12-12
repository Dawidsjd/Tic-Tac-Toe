using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace kolko
{
    public partial class Form2 : Form
    {

        int runda = 0;
        int winsX = 0;
        int winsO = 0;
        Random rand = new Random();
        public Form2()
        {
            InitializeComponent();
            
        }

        public void End()
        {
            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X" || 
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Koniec Gry. Wygrał X");
                Reset();
                winsX++;
                winsXlabel.Text = winsX.ToString();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Koniec Gry. Wygrał O");
                Reset();
                winsO++;
                winsOlabel.Text = winsO.ToString();


            }
            else if(button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != ""
                && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Remis");
                Reset();
            }
            
        }

        public void TitleConvert()
        {
            if (runda == 0)
            {
                labe45.Text = "X";
            }
            else
            {
                labe45.Text = "O";
            }
        }

        public void Klikanie(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (!string.IsNullOrEmpty(button.Text))
            {
                return;
            }
            switch (runda)
            {
                case 0:
                    button.Text = "X";
                    runda = 1;
                    button.BackColor = panel1.BackColor;
                    TitleConvert();
                    End();
                    break;
                case 1:
                    button.Text = "O";
                    runda = 0;
                    button.BackColor = panel2.BackColor;
                    TitleConvert();
                    End();
                    break;

                default:
                    {
                        break;
                    }
            }
        }
        

        public void Reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = Color.FromArgb(255, 255, 255);
            button2.BackColor = Color.FromArgb(255, 255, 255);
            button3.BackColor = Color.FromArgb(255, 255, 255);
            button4.BackColor = Color.FromArgb(255, 255, 255);
            button5.BackColor = Color.FromArgb(255, 255, 255);
            button6.BackColor = Color.FromArgb(255, 255, 255);
            button7.BackColor = Color.FromArgb(255, 255, 255);
            button8.BackColor = Color.FromArgb(255, 255, 255);
            button9.BackColor = Color.FromArgb(255, 255, 255);
            //Close();
        }
    }
}
