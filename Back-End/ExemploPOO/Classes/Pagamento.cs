using System;

namespace ExemploPOO.Classes
{
    public class Pagamento
    {
        private DateTime Data;

        protected float Valor = 2599f;

        public string Cancelar(){
            return "Pagamento cancelado";
        }
    }
}