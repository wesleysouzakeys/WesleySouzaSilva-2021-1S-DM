using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int litros;
            char fuel;

            Console.WriteLine("Quantos litros de combustível foram adquiridos ?");
            litros = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($@"
Qual o tipo de combustível comprado ?

'a' para alcool
'g' para gasolina
");

            fuel = Console.ReadLine()[0];

            switch (fuel)
            {
                case 'a':
                alcool(litros);
                    break;

                case 'g':
                gasolina(litros);
                    break;

                default:
                    break;
            }
            
        }

        static double alcool(double litros)
        {
            if (litros <= 20)
            {
                litros = litros * 4.90;
                litros = litros * 0.3;
            }else
            {
                litros = litros * 4.90;
                litros = litros * 0.5;
            }
            Console.Clear();

            Console.WriteLine($"O valor total a ser pago é: R${litros.ToString("N2")}");

            return litros;
        }
        static double gasolina(double litros)
        {
            if (litros <= 20)
            {
                litros = litros * 5.30;
                litros = litros * 0.4;
            }else
            {
                litros = litros * 5.30;
                litros = litros * 0.6;
            }
            Console.Clear();

            Console.WriteLine($"O valor total a ser pago é: R${litros.ToString("N2")}");

            return litros;
        }

    }
}
