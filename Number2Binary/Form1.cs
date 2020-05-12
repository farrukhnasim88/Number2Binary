using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number2Binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) || string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please enter a value");
            }

            else
            {
                int input = int.Parse(txtInput.Text);
                int save = input;

                if (input <= 0 )
                {
                    MessageBox.Show("Please enter whole number");
                }

                else
                {
                    int count = 0;
                    string binary = "";

                    while (input >= 1)
                    {
                        int div = input / 2;
                        int rem = input % 2;
                        if (rem == 1)
                        {
                            count++;
                            string a = rem.ToString();
                            binary += a;
                        }
                        else
                        {

                            binary += 0.ToString();
                        }


                        input = div;


                    }

                    char[] reverse = binary.ToCharArray();
                    Array.Reverse(reverse);
                    string n = "";
                    n = new string(reverse);


                    MessageBox.Show("Binary number of  " + save.ToString() + " => " + n + "\nToatl number of Ones in this binary are => " + count.ToString());
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
