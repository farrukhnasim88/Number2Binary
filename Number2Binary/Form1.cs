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
            // Checking Exceptions

            if (string.IsNullOrEmpty(txtInput.Text) || string.IsNullOrWhiteSpace(txtInput.Text) || (int.Parse(txtInput.Text)== 0))
            {
                MessageBox.Show("Please enter a whole number only");
            }

            else
            {
                // Parsing
                int input = int.Parse(txtInput.Text);
                int save = input;
                    int count = 0;
                // This string is for concating
                    string concats = "";

                    while (input >= 1)
                    {
                    // Binary rule divide on 2
                        int div = input / 2;
                    // find the remainder
                        int rem = input % 2;
                        if (rem == 1)
                        {
                            count++;
                        // converting int to string
                            string add = rem.ToString();
                            concats += add;
                        }
                        else
                        {

                            concats += 0.ToString();
                        }

                        // input assigned to half of the value
                        input = div;


                    }

                    // Createing Char[] to store string for reversing 
                    char[] reverse = concats.ToCharArray();
                // reversing the array
                    Array.Reverse(reverse);
                // reversing back to string
                    string binary = new string(reverse);
                    
                    MessageBox.Show("Binary number of  " + save.ToString() + " => " + binary + "\nToatl number of Ones in this binary are => " + count.ToString());
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
