using System;

namespace ExemploPOO.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira;

        public string Numero;

        public string Titular;

        public string Cvv;

        public string SalvarCartao(){
            Console.WriteLine($"Digite a Bandeira do seu cartão");
            Bandeira = Console.ReadLine();
            
            Console.WriteLine($"Digite o Número do seu Cartão");
            Numero = Console.ReadLine();
            
            Console.WriteLine($"Digite o Nome do Titular");
            Titular = Console.ReadLine();
            
            Console.WriteLine($"Digite o CVV do seu cartão");
            Cvv = Console.ReadLine();
            
            return $"Cartão de {Numero} foi salvo com sucesso!";
        }
    }
}