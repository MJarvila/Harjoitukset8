using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj8Teht1
{
    class Order : OrderItem
    {
        public uint Id { get; set; }
        public DateTime Date { get; set; }
        public List<OrderItem> OrderItems = new List<OrderItem>();


        public Order(uint id, DateTime date, List<OrderItem> item)
        {
            OrderItems = new List<OrderItem>();
            Id = id;
            Date = date;
            OrderItems = item;
        }

        public Order()
        {

        }
    }
}
