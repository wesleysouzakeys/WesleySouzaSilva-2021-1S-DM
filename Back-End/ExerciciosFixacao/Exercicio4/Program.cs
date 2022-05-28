using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int[10];
            Console.WriteLine("Escreva 10 valores aleatórios");

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($@"Escreva o {i + 1}° valor");
                valor[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Array.Sort(valor);

            Console.WriteLine($@"
-O menor número digitado foi {valor[0]}
-O maior número digitado foi {valor[9]}");
        }
    }
}
