using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];

            Console.WriteLine("Digite 15 números");

            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($@"Digite o {i + 1}° número");
                numeros[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Array.Reverse(numeros);

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
