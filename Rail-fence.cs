using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace RailFence
{
    public static class RailFence
    {

        static void Main(string[] args)
        {
            Run();
            Console.ReadKey();
        }



        public static void Run()
        {
            Console.WriteLine("RailFenceCipher");
            Console.WriteLine();

            Console.WriteLine("Shkruani tekstin:");
            string clearText = Console.ReadLine();

            Console.WriteLine("Shkruani numrin e celesit:");
            int key = Convert.ToInt32(Console.ReadLine());

            string cipherText = Cipher(clearText, key);
            Console.WriteLine("Teksti i enkriptuar: {0}", cipherText);

            Console.WriteLine();

            string decipherText = Decipher(cipherText, key);
            Console.WriteLine("Teksti i dekriptuar:  {0}", decipherText);

            Console.ReadKey();
        }

        private static char[][] BuildCleanMatrix(int rreshtat, int kolonat)
        {
            char[][] result = new char[rreshtat][];

            for (int rreshti = 0; rreshti < result.Length; rreshti++)
            {
                result[rreshti] = new char[kolonat];
            }

            return result;
        }

        private static string BuildStringFromMatrix(char[][] matrix)
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

        private static char[][] Transpose(char[][] matrix)
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