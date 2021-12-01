using System;

namespace Ucu.Poo.Defense
{
    public class PromoCode : IOfferItem
    {
        private string code {get;set;}
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }

        public PromoCode(string code, int amount)
        {
            if(amount >= 0)
            {
                throw new ArgumentException("Debe ser negativo");
            }
            
            this.code = code;
            this.SubTotal = amount;
        }
    }
}