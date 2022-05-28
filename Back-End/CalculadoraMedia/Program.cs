using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nomePessoa =  Console.ReadLine();

            Console.WriteLine("Bom dia " + nomePessoa);

            Console.Write("Digite o primeiro número");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número");
            int terceiroNumero = int.Parse(Console.ReadLine());

            int soma = primeiroNumero + segundoNumero;

            Console.WriteLine("A soma dos numeros é: " + soma );

            Console.WriteLine("Vamos somar médias!");

            int somaMedia = primeiroNumero + segundoNumero + terceiroNumero ;
            int media = somaMedia / 3;

            Console.WriteLine("A média é: " + media );

            if (media >= 7)
            {
                Console.WriteLine("Aluno Aprovado");
            } 
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }
            
            Console.ReadKey();
        }
    }
}
