using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    enum Requirements
    {
        Name = 8,
        Password = 8,
        CreditCard = 16,
        Login = 6
    }
    class Customer
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        public string CreditCard { get; set; }

    }
}
