using System;

namespace RockIn
{
    class Program
    {
        static string[] inscritos = null;
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine($@"
 _________________________________           
|                                 |
|Como deseja prosseguir ?         | 
|                                 |
|1- Verificador de Idade          |
|2- Cadastrar pessoas             |
|3- Listar participantes          |
|4- Sair                          |
|_________________________________|
            ");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    VerificadorIdade();
                    break;
                case 2:
                    Cadastrar();
                    break;
                case 3:
                    Listar();
                    break;
                default:
                    Sair();
                    break;
            }

        }

        static void VerificadorIdade()
        {
            Console.WriteLine("Olá, quantos anos você tem ?");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 16)
            {
                Console.WriteLine("Você está com seus pais ? s/n");
                char p = char.Parse(Console.ReadLine().ToLower());

                switch (p)
                {
                    case 's':
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Seja muito bem-vindo!!");
                        Console.ResetColor();
                        break;
                    case 'n':
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Desculpe, você não tem idade o suficiente.");
                        Console.ResetColor();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Seja muito bem-vindo!!");
                Console.ResetColor();
            }

            Menu();
        }
        static string[] Cadastrar()
        {

            Console.WriteLine("Quantas pessoas desejam se inscrever ?");
            int qtdPessoas = int.Parse(Console.ReadLine());

            inscritos = new string[qtdPessoas];

            for (var i = 0; i <= (qtdPessoas - 1); i++)
            {
                Console.WriteLine($"Qual o nome da {i + 1}° Pessoa?");
                inscritos[i] = Console.ReadLine();
            }

            Menu();
            return inscritos;
        }

        static void Listar()
        {
            int c = 0;

            Console.Clear();

            foreach (var item in inscritos)
            {
                Console.WriteLine($"1-{inscritos[c]}");
                c++;
            }

            Menu();
        }
        static void Sair()
        {
            Environment.Exit(0);
        }
    }
}