using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do produto adquirido ?");
            string nomeProduto = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Quantas unidades foram adquiridas ?");
            int qtd = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Qual o Preço unitário desse produto ?");
            double preco = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($@"
--Informações do produto {nomeProduto}

-O total sem desconto é de: {Total(qtd, preco).ToString("N2")}
-Após o desconto o total a pagar é de: R${Desconto(qtd, preco)}
            ");
        }

        static double Total(int qtd, double preco)
        {
            double total = qtd * preco;
            return total;
        }

        static double Desconto(int qtd, double preco)
        {
            double total = qtd * preco;
            double desconto;
            double totalDesconto;

            if (qtd <= 5)
            {
                desconto = total * 0.02;
                totalDesconto = total - desconto;
            }
            else if (qtd > 5 && qtd <= 10)
            {
                desconto = total * 0.03; 
                totalDesconto = total - desconto;
            }
            else
            {
                desconto = total * 0.05;
                totalDesconto = total - desconto;
            }

            return totalDesconto;
        }
    }
}
