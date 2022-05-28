using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool igualdade = false;

            do
            {

                Console.WriteLine("Digite seu nome de Usuário: \n");
                string user = Console.ReadLine();

                Console.WriteLine("Digite sua senha: \n");
                string senha = Console.ReadLine();  

                if (user == senha)
                {
                    Console.WriteLine("Seu usuário não pode ser igual a sua senha, tente novamente");
                }
                else
                {
                    igualdade = true;
                }
            } while (igualdade == false);
        }
    }
}
