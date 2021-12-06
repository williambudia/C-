using System;
using System.Collections.Generic;
using System.Text;

namespace Exame
{
    class CpfValidator
    {

        /*
         Carrega 10 cpfs na matriz e depois faz a verificação, alterando a segunda coluna
         */
        public string[,] validate()
        {
            string[,] cpfs = {
                {
                    "47185798809",
                    "32155577745", /* CPF inválido */
                    "13705412019",
                    "67279713076",
                    "27409404086",
                    "61321505019",
                    "23705648063",
                    "92053757051",
                    "86805944074",
                    "69998060044"
                },
                {
                    "0", "0","0","0","0","0","0","0","0","0",
                }
            };

            for (int i = 0; i < 10; i++)
            {
                string cpf = cpfs[0, i];
                var array = cpf.ToCharArray();
                double number1 = 0;
                double number2 = 0;
                int digit1 = int.Parse(array[cpf.Length - 2].ToString());
                int digit2 = int.Parse(array[cpf.Length - 1].ToString());

                for (int j = 0; j < cpf.Length - 2; j++)
                {
                    number1 += double.Parse(array[j].ToString()) * (j + 1);
                    number2 += double.Parse(array[j].ToString()) * j;

                    if (j == cpf.Length - 3)
                    {
                        number2 += double.Parse(array[j + 1].ToString()) * (j + 1);
                    }


                }
                var rest1 = number1 % 11;
                var rest2 = number2 % 11;
                if ((rest1 == digit1 || rest1 == 10 && digit1 == 0) && (rest2 == digit2 || rest2 == 10 && digit2 == 0))
                {
                    cpfs[1, i] = "1";
                }
            }
            return cpfs;
        }

        /*
        Printa a matriz
        */
        public static void printMatrix(string[,] matrix)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("CPF: " + matrix[0, i] + " Verificação: " + matrix[1, i]);
            }
            Console.WriteLine("\n");
        }
    }
}
