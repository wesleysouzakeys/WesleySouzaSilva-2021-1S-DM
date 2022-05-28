using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            Console.WriteLine("Escreva 10 nomes por favor");

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($@"Escreva o {i + 1}° nome");
                nomes[i] = Console.ReadLine().ToLower();
                Console.Clear();
            }

            Console.WriteLine("Qual nome você deseja verificar em nossos sistemas ?");
            string nome = Console.ReadLine();

            int procura = Array.IndexOf(nomes, nome);

            int c = -1;

            if (procura > c)
            {
                Console.Clear();
                Console.WriteLine("Achei!!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Não encontrado!!");
            }
        }
    }
}
