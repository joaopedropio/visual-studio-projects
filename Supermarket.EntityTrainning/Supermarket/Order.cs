using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Order
    {
        public int Id { get; set; }
        public Customer Customer{ get; set; }
        public Dictionary<int, Product> Cart{ get; set; }
        public DateTime Date { get; set; }
    }
}
