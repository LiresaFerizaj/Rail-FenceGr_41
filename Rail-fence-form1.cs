using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int celesi = Convert.ToInt32(textBox2.Text);
            string clearText = textBox1.Text;
            textBox3.Text = Run.Cipher(clearText, celesi);
            // textBox4.Text = Run.Decipher(clearText, key);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int celesi = Convert.ToInt32(textBox2.Text);
            string cipherText = textBox3.Text;
            textBox4.Text = Run.Decipher(cipherText, celesi);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


    
