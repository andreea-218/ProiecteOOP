using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrice
    {
        private static int n = 10;
        private int[,] matriceA = new int[n, n];
        private int[,] matriceB = new int[n, n];
        private int[,] Rezultat= new int[n, n];

        public void citire(int[,] matrice)
        {
            for (int i = 0; i < matriceA.GetLength(0); i++)
            {
                for (int j = 0; j < matriceA.GetLength(1); j++)
                {
                    matriceA[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void adunare(int[,] matrice)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Rezultat[i, j] = matriceA[i, j] + matriceB[i, j];
                }
            }

        }
        public void inumtire(int[,] matrice)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Rezultat[i, j] = matriceA[i, j] * matriceB[i, j];
                }
            }

        }
        public void scadere(int[,] matrice)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   Rezultat[i, j] = matriceA[i, j] - matriceB[i, j];
                }
            }
        }

        public void putere(int[,] matrice)
        {
            int[,] aux = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int a = 0, b = 0; a < n; a++, b++)
                    {
                        aux[i, j] += Rezultat[i, a] * matriceA[b, j];
                    }
                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Rezultat[i, j] = aux[i, j];
            }
        }

        public static void afisare(int[,] matrice)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(matrice[i, j] + " ");
                Console.WriteLine();
            }
           
        }

        public static void inversa(int[,] matrice)
        {
            

        }

    }
}
