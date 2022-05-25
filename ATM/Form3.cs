using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            // The password character is an asterisk.
            textBox1.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox1.MaxLength = 6;

            if (textBox1.MaxLength < 6)
            {
                MessageBox.Show("Incorrect PIN!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.MaxLength < 6)
            {
                MessageBox.Show("Incorrect PIN!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            else
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }
    }
}
