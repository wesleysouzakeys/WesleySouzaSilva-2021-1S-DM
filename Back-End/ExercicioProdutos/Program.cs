using System;

namespace Tentativa1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomeProdutos;
            int[] quantiProduto;
            double[] valor;
            int quantiProdutos;

            Console.WriteLine("Quantos produtos você deseja cadastrar ?");
            quantiProdutos = int.Parse(Console.ReadLine());

            nomeProdutos = new string[quantiProdutos];
            quantiProduto = new int[quantiProdutos];
            valor = new double[quantiProdutos];

            for (var i = 0; i <= (quantiProdutos - 1); i++)
            {
                Console.WriteLine("Qual o nome do " + (i + 1) + "° produto ?");
                nomeProdutos[i] = Console.ReadLine();

                Console.WriteLine("Qual a quantidade do " + (i + 1) + "° produto ?");
                quantiProduto[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual o valor do " + (i + 1) + "° produto ?");
                valor[i] = double.Parse(Console.ReadLine());
            }

            for (var i = 0; i < quantiProdutos; i++)
            {
                Console.WriteLine($@" 
                {nomeProdutos[i]}
                {quantiProduto[i]}
                {valor[i].ToString("N2")}
                ");
            }
        }
    }
}
