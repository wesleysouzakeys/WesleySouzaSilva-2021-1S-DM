using System;

namespace ExemploPOO.Classes
{
    public class Debito : Cartao
    {
        private float Saldo = 10600f;

        public void Pagar(){
            float valor = this.Valor;

            if (valor > Saldo)
            {
                Console.WriteLine($"Você não possui saldo suficiente para pagar esse valor!");
                
            } else
            {
                Console.WriteLine($"O valor de {valor:C2} foi pago com sucesso!");
                
            }
        }
    }
}