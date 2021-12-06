using System;
using System.Collections.Generic;
using System.Text;

namespace Exame
{
    class RandomNumbers
    {
        /*
            Função que gera matrix de números aleatórios
         */
        public int[,] generateRamdomNumbers()
        {
            int[,] randomNumbers = new int[10, 10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var number = random.Next(1, 50);
                    randomNumbers[i, j] = number;
                }
            }

            return randomNumbers;
        }

        /*
         Função que verifica números proibidos e faz o replace por 0
         */
        public void validateRandomsNumbers(int[,] array)
        {
            int[] notAllowedNumbers = { 2, 11, 13, 21 };

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (notAllowedNumbers[k] == array[i, j])
                        {
                            array[i, j] = 0;
                        }
                    }
                }
            }
        }

        /*
         Printa a matriz
         */
        public static void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
    }
}
