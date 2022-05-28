using System;

namespace Estruturas_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Qual a sua idade ?\n");
            int idadePessoa = int.Parse(Console.ReadLine());

            int idadeMeses = idadePessoa * 12;
            Console.WriteLine("A sua idade em Meses é " + idadeMeses );

            int idadeDias = idadePessoa * 365;
            Console.WriteLine("A sua idade em Dias é " + idadeDias );

            int idadeHoras = idadePessoa * 8760;
            Console.WriteLine("A sua idade em Horas é " + idadeHoras );

            int idadeMinutos = idadePessoa * 525600;
            Console.WriteLine("A sua idade em Minutos é " + idadeMinutos );

            

        }
    }
}
