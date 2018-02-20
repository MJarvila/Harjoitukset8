using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj8Teht1
{
    class Customer : Order
    {
        public string CustomerName { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string name)
        {
            CustomerName = name;
        }

        public void PrintOrderData()
        {
            foreach (Order order in Orders)
            {
                Console.WriteLine("OrderID {0} & date {1}", order.Id, order.Date);
                foreach (OrderItem item in order.OrderItems)
                {
                    Console.WriteLine("Item: {0} Count: {1}", item.Name, item.ItemCount);
                }
            }
        }
    }
}
