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
public class Run
{
    public static char[][] BuildCleanMatrix(int rreshtat, int kolonat)
    {
        char[][] rezultati = new char[rreshtat][];

        for (int rreshti = 0; rreshti < rezultati.Length; rreshti++)
        {
            rezultati[rreshti] = new char[kolonat];
        }

        return rezultati;
    }
    public static string BuildStringFromMatrix(char[][] matrix)
    {
        string rezultati = string.Empty;

        for (int rreshti = 0; rreshti < matrix.Length; rreshti++)
        {
            for (int kolona = 0; kolona < matrix[rreshti].Length; kolona++)
            {
                if (matrix[rreshti][kolona] != '\0')
                {
                    rezultati += matrix[rreshti][kolona];
                }
            }
        }

        return rezultati;
    }
    public static char[][] Transpose(char[][] matrix)
    {
        char[][] rezultati =
                BuildCleanMatrix(matrix[0].Length, matrix.Length);

        for (int rreshti = 0; rreshti < matrix.Length; rreshti++)
        {
            for (int kolona = 0; kolona < matrix[rreshti].Length; kolona++)
            {
                rezultati[kolona][rreshti] = matrix[rreshti][kolona];
            }
        }

        return rezultati;
    }
    public static string Cipher(string clearText, int celesi)
    {
        string rezultati = string.Empty;

        char[][] matrix = BuildCleanMatrix(celesi, clearText.Length);

        int inkrementiRreshtit = 1;
        for (int rreshti = 0, kolona = 0; kolona < matrix[rreshti].Length; kolona++)
        {
            if (
                    rreshti + inkrementiRreshtit == matrix.Length ||
                    rreshti + inkrementiRreshtit == -1
                    )
            {
                inkrementiRreshtit *= -1;
            }

            matrix[rreshti][kolona] = clearText[kolona];

            rreshti += inkrementiRreshtit;
        }

        rezultati = BuildStringFromMatrix(matrix);

        return rezultati;
    }

    public static string Decipher(string cipherText, int celesi)
    {
        string rezultati = string.Empty;

        char[][] matrix = BuildCleanMatrix(celesi, cipherText.Length);

        int inkrementiRreshtit = 1;
        int textIdx = 0;

        for (
                int selektimiRreshtit = 0;
                selektimiRreshtit < matrix.Length;
                selektimiRreshtit++
                )
        {
            for (
                    int rreshti = 0, kolona = 0;
                    kolona < matrix[rreshti].Length;
                    kolona++
                    )
            {
                if (
                        rreshti + inkrementiRreshtit == matrix.Length ||
                        rreshti + inkrementiRreshtit == -1
                        )
                {
                    inkrementiRreshtit *= -1;
                }

                if (rreshti == selektimiRreshtit)
                {
                    matrix[rreshti][kolona] = cipherText[textIdx++];
                }

                rreshti += inkrementiRreshtit;
            }
        }

        matrix = Transpose(matrix); 
         rezultati = BuildStringFromMatrix(matrix);

        return rezultati;
    }

}

