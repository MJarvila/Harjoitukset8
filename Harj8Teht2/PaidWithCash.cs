using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj8Teht2
{
    class PaidWithCash : ITransaction
    {
        private float Cash { get; set; }
        private float Amount { get; set; }

        public PaidWithCash(float amount)
        {
            Amount = amount;
            Cash += amount;
        }

        public float ShowCash()
        {
            return Cash;
        }

        public string ShowTransaction()
        {
            return "Cash payment on " + DateTime.Now + " with amount of " + Amount;
        }

        public float GetAmount()
        {
            throw new NotImplementedException();
        }
    }
}
