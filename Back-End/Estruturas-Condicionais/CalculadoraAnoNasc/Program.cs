using System;

namespace CalculadoraAnoNasc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano você nasceu ?");
            int anoNasc = int.Parse(Console.ReadLine());

            DateTime moment = DateTime.Now;
            int anoAtual = moment.Year;

            int idadePessoa = anoAtual - anoNasc;
            Console.WriteLine("Sua idade é " + idadePessoa);

            double idadeSemanas = idadePessoa * 52.1429;
            Console.WriteLine("Sua idade em semanas é " + idadeSemanas);
            
        }
    }
}
