using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja iniciar o programa de tabuada ? s/n");
            char validation = char.Parse(Console.ReadLine());
            bool v = false;

            do
            {

                switch (validation)
                {
                    case 's':
                        Console.WriteLine("Escolha um número de 1 a 10 para ver sua devida tabuada");
                        int numeroEscolhido = int.Parse(Console.ReadLine());

                        switch (numeroEscolhido)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                            case 8:
                                break;
                            case 9:
                                break;
                            case 10:
                                break;
                            default:
                                break;
                        }

                        break;
                    case 'n':
                        Console.WriteLine("Ok! Obrigado.");
                        break;
                    default:
                        break;
                }

            } while (v == false);

            // Criar os métodos de tabuada do 1 ao 10
        }
    }
}
