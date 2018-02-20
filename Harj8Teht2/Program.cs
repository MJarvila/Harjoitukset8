using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj8Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            PaidWithCard visa = new PaidWithCard(123, "L5387");
            PaidWithCard mastercard = new PaidWithCard(66, "943787535-3434");
            Console.WriteLine(visa.ShowTransaction());
            Console.WriteLine(mastercard.ShowTransaction());
            PaidWithCash cash1 = new PaidWithCash(50);
            PaidWithCash cash2 = new PaidWithCash(150);
            Console.WriteLine(cash1.ShowTransaction());
            Console.WriteLine(cash2.ShowTransaction());

        }
    }
}
