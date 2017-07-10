﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEquality
{
    public class Food
    {
        private string _name;
        public string Name { get { return _name; } }
        public Food(string name)
        {
            this._name = name;
        }

        public static bool operator ==(Food a, Food b)
        {
            return (a.Name == b.Name) ? true : false;
        }
        public static bool operator !=(Food a, Food b)
        {
            return (a.Name != a.Name) ? true : false;
        }
        
        public override string ToString()
        {
            return _name;
        }
    }
}
