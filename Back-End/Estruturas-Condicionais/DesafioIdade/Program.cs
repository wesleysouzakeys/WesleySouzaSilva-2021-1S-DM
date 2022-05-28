using System;

namespace DesafioIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Nadador \nInsira sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if(idade < 5)
            {
                Console.WriteLine("Erro !!! Você não tem idade para competir");
            }
            else if(idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Sua categoria é Infantil A");
            }
            else if(idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Sua categoria é Infantil B");
            }
            else if(idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Sua categoria é Juvenil A");
            }
            else if(idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Sua categoria é Juvenil B");
            }
            else
            {
                Console.WriteLine("Sua categoria é Sênior");
            }
            

        }
    }
}
