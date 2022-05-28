using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validacaoEscolha = false;
            string escolha;

            do
            {
                
            Console.WriteLine($@"
Qual operação você deseja realizar ?

'so' para somar
'su' para subtrair
'mu' para multiplicar
'di' para dividir
 ");

            escolha = Console.ReadLine();

            switch (escolha)
            {
                case "so":
                validacaoEscolha = true;
                Console.Clear();
                    break;

                case "su":
                validacaoEscolha = true;
                Console.Clear();
                    break;

                case "mu":
                validacaoEscolha = true;
                Console.Clear();
                    break;

                case "di":
                validacaoEscolha = true;
                Console.Clear();
                    break;

                default:
                Console.Clear();
                Console.WriteLine("Opção inválida, por favor escolha uma das anteriores!");
                    break;
            }
                

            } while (validacaoEscolha == false);


            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case "so":

                    Somar(n1, n2);
                    Console.WriteLine($"Seu resultado é: {Somar(n1, n2)}");

                    break;

                case "su":

                    Subtrair(n1, n2);
                    Console.WriteLine($"Seu resultado é: {Subtrair(n1, n2)}");

                    break;

                case "mu":

                    Multiplicar(n1, n2);
                    Console.WriteLine($"Seu resultado é: {Multiplicar(n1, n2)}");

                    break;

                case "di":

                    Dividir(n1, n2);
                    Console.WriteLine($"Seu resultado é: {Dividir(n1, n2)}");

                    break;

                default:
                    break;
            }

        }

        static int Somar(int primeiroNumero, int segundoNumero)
        {
            int resultado = primeiroNumero + segundoNumero;
            return resultado;
        }
        static int Subtrair(int primeiroNumero, int segundoNumero)
        {
            int resultado = primeiroNumero - segundoNumero;
            return resultado;
        }
        static int Multiplicar(int primeiroNumero, int segundoNumero)
        {
            int resultado = primeiroNumero * segundoNumero;
            return resultado;
        }
        static int Dividir(int primeiroNumero, int segundoNumero)
        {
            int resultado = primeiroNumero / segundoNumero;
            return resultado;
        }
    }
}
