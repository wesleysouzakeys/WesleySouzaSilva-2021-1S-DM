using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool NotaFinal = false;

            do
            {


                Console.WriteLine("Digite um número entre 0 e 10\nDigite aqui: ");
                int nota = int.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 10)
                {
                    Console.WriteLine("Esta nota é válida!");
                    NotaFinal = true;
                }
                
                else{
                    Console.WriteLine("Esta nota é inválida, digite outro número");
                }

            } while (NotaFinal == false);
        }
    }
}
