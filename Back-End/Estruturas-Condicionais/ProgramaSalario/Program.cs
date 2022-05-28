using System;

namespace ProgramaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu salário ?\n Digite aqui:");
            int salario = int.Parse(Console.ReadLine());

            double pencentual = 30.0 / 100.0;
            double valor_final = salario + (pencentual * salario);

            Console.WriteLine("O valor do seu salário reajustado é " + valor_final);

            if (salario < 500)
            {
                Console.WriteLine("Parabéns, você tem direito a um aumento");
            }else
            {
                Console.WriteLine("Desculpa, seu direito foi negado");
            }
        }
    }
}
