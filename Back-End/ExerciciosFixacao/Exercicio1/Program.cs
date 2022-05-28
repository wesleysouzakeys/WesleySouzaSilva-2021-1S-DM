using System;
using System.Data;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu ano de nascimento: ");
            int anoNasc = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            if (anoAtual - anoNasc < 16)
            {
                Console.Clear();
                Console.WriteLine("Você ainda não pode votar");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Você já está apto a votar");
            }
        }
    }
}
