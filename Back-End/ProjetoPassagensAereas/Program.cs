using System;
using System.Collections.Generic;

namespace ProjetoPassagensAereas
{
    class Program
    {
        static List<Passagem> passagens = new List<Passagem>();

        static void Main(string[] args)
        {
            // Console.WriteLine("Olá!, digite sua senha");

            // Logar();

            Menu();

        }

        static void Logar()
        {
            bool validacao = false;

            do
            {
                int senha = int.Parse(Console.ReadLine());

                if (senha == 123456)
                {
                    validacao = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Senha Inválida! Tente novamente");
                }
            } while (validacao == false);
        }

        static List<Passagem> Cadastrar()
        {
            string escolha;

            do
            {

                Passagem p = new Passagem();

                Console.WriteLine($"Digite o Nome do Passageiro:");
                p.NomePassageiro = Console.ReadLine();

                Console.WriteLine($"Digite a Origem do voo:");
                p.Origem = Console.ReadLine();

                Console.WriteLine($"Digite o destino do voo:");
                p.Destino = Console.ReadLine();

                Console.WriteLine($"Digite a data do voo:");
                p.Data = Console.ReadLine();

                passagens.Add(p);

                Console.WriteLine($"Deseja cadastrar mais uma passagem ? sim/nao");
                escolha = Console.ReadLine().ToLower();

            } while (escolha == "sim");

            Menu();
            return passagens;

        }

        static void Listar(List<Passagem> passagens)
        {
            int c = 1;

            foreach (var p in passagens)
            {
                Console.WriteLine($@"
Detalhes da {c}° Passagem:

Nome do Passageiro: {p.NomePassageiro}
Origem do Voo: {p.Origem}
Destino do Voo: {p.Destino}
Data do Voo: {p.Data}

                ");
                c++;
            }

            Console.WriteLine("Deseja voltar ao menu ? sim/nao");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "sim":
                    Menu();
                    break;
                default:
                    Console.WriteLine($"Obrigado por utilizar nossos sistemas!");
                    Environment.Exit(0);
                    break;
            }

        }

        static void Sair()
        {
            Environment.Exit(0);
        }

        static void Menu()
        {
            Console.WriteLine($@"
 _______________________
|                       |
|                       |            
|1- Cadastrar Passagens |
|2- Listar Passagens    |
|3- Sair                |
|                       |
|_______________________|                  
            ");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:

                    Cadastrar();

                    break;
                case 2:

                    Listar(passagens);

                    break;
                case 3:

                    Sair();

                    break;
                default:
                    break;
            }
        }
    }
}