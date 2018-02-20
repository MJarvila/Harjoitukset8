using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj8Teht2
{
    class PaidWithCard : ITransaction
    {
        private string Card { get; set; }
        private float Amount { get; set; }

        public PaidWithCard(float amount, string card)
        {
            Amount = amount;
            Card = card;
        }
        public string ShowTransaction()
        {
            return "Credit card transaction via card " + Card + " on " + DateTime.Now + " with amount of " + Amount;
        }

        public float GetAmount()
        {
            return Amount;
        }
    }
}
