using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Validação do nome
            bool validacao1 = false;
            string nome;

            do
            {

                Console.WriteLine("Escreva seu nome (não deixe o campo em branco)\n");
                nome = Console.ReadLine();

                if (nome == "")
                {
                    Console.WriteLine("Não deixe o campo \"nome\" em branco");
                }
                else
                {
                    validacao1 = true;
                }

            } while (validacao1 == false);

            // Validação da Idade
            bool validacao2 = false;
            int idade;

            do
            {

                Console.WriteLine("Escreva a sua idade\n");
                idade = int.Parse(Console.ReadLine());

                if (idade >= 0 && idade <= 150)
                {
                    validacao2 = true;
                }
                else
                {
                    Console.WriteLine("Idade inválida, tente novamente");
                }
            } while (validacao2 == false);

            // Validação do Salario
            bool validacao3 = false;
            int salario;

            do
            {

                Console.WriteLine("Escreva seu salário\n");
                salario = int.Parse(Console.ReadLine());

                if (salario > 0)
                {
                    validacao3 = true;
                }
                else
                {
                    Console.WriteLine("Seu salário não pode ser menor que 0, tente novamente");
                }
            } while (validacao3 == false);

            bool validacao4 = false;
            char estadoCivil;

            do
            {

                Console.WriteLine($@"Escreva seu estado civil:
    -'s' se você é solteiro
    -'c' se você é casado
    -'v' se você é viuvo
    -'d' se você é divorciado");

            estadoCivil = Convert.ToChar(Console.ReadLine());

                switch (estadoCivil)
                {
                    case 's':
                    case 'c':
                    case 'v':
                    case 'd':

                        validacao4 = true;

                        break;
                    default:

                        Console.WriteLine("Você inseriu uma opção inválida, tente novamente!");

                        break;
                }
            } while (validacao4 == false);

            Console.WriteLine($@"Obrigado por usar nossos sistemas, aqui estão suas informações

    Seu nome é {nome}
    Sua idade é {idade}
    Seu salário é {salario}");
                if (estadoCivil == 's')
                {
                    Console.WriteLine("Solteiro");
                }
                else if (estadoCivil == 'c')
                {
                    Console.WriteLine("Casado");           
                }
                else if (estadoCivil == 'v')
                {
                    Console.WriteLine("Viúvo");           
                }else
                {
                    Console.WriteLine("Divorciado");           
                } 
        }
    }
}
