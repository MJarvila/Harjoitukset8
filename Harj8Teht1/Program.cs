using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj8Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Customer customer = new Customer("Kekkonen");

                OrderItem notes = new OrderItem("Notes", 666);
                OrderItem skiis = new OrderItem("Karhu skiis", 2);

                Order order1 = new Order(1, DateTime.Now, new List<OrderItem>() { notes, skiis });

                customer.Orders = new List<Order>() { order1 };
                customer.PrintOrderData();
            }
        }
    }
}
