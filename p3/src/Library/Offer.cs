using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Offer
    {
        public DateTime EndDate { get; set; }

        public int Total { get; set; }

        public IReadOnlyCollection<OfferItem> Items
        {
            get
            {
                return new ReadOnlyCollection<OfferItem>(this.items);
            }
        }

        private IList<OfferItem> items = new List<OfferItem>();

        public Offer(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(OfferItem item)
        {
            this.items.Add(item);
            this.Total += (item.Price*item.Quantity);
        }

        
        /*
        public void Total(OfferItem item)
        {
            this.Total += (item.Price*item.Quantity);
        }
        */
        
        public void RemoveItem(OfferItem item)
        {
            this.items.Remove(item);
        }

        public string AsText()
        {
            StringBuilder asText = new StringBuilder();
            foreach(OfferItem item in Items)
            {
                asText.Append(item.Residue.Name);
                asText.Append(item.Quantity);
                asText.Append(item.Price);
            }

            return asText.ToString();
        }
    }
}