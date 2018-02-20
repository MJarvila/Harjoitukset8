using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj8Teht1
{
    class OrderItem
    {
        public string Name { get; set; }
        public uint ItemCount { get; set; }

        public OrderItem(string name, uint count)
        {
            Name = name;
            ItemCount = count;
        }

        public OrderItem()
        {

        }
    }
}
