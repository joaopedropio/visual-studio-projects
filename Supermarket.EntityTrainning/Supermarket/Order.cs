using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Order
    {
        public int Id { get; set; }
        [Required]
        public Customer Customer{ get; set; }
        [Required]
        public Dictionary<int, Product> List { get; set; }
        public DateTime Date { get; set; }
    }
}
