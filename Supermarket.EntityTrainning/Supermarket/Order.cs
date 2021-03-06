﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public Customer Customer{ get; set; }
        [Required]
        public Dictionary<Product, int> List { get; set; }
        public DateTime Date { get; set; }

        public double TotalPrice()
        {
            double total = 0;
            foreach (var item in List)
            {
                total += item.Value * item.Key.Price;
            }
            return total;
        }
    }
}
