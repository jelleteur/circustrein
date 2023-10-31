using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Animal
    {
        public string Name { get; set; }
        public _Size Size { get; set; }
        public _Diet Diet { get; set; }

        public Animal(string name, _Size size, _Diet diet)
        {
            Name = name;
            Size = size;
            Diet = diet;
        }

        public _Size GetSize()
        {
            return Size;
        }

        public bool IsCarnivore(_Diet diet)
        {
            if (diet == _Diet.carnivore)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
