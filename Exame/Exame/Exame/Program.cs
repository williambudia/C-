using System;
using System.Collections.Generic;
using System.Text;

namespace Exame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Validador de CPF\n");
            CpfValidator cpfValidator = new CpfValidator();
            string[,] tmp = cpfValidator.validate();
            CpfValidator.printMatrix(tmp);

            Console.Write("-------------------\n");

            Console.WriteLine("Testando Validador de números aleatórios\n");
            RandomNumbers randomNumbers = new RandomNumbers();
            int[,] random = randomNumbers.generateRamdomNumbers();
            RandomNumbers.printMatrix(random);

            Console.WriteLine("Após a substituição:\n");
            randomNumbers.validateRandomsNumbers(random);
            RandomNumbers.printMatrix(random);
            Console.Write("-------------------\n");
        }
    }
}
