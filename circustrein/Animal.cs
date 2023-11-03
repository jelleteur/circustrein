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
        private string Name { get; set; }
        private _Size Size { get; set; }
        private _Diet Diet { get; set; }

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

        public _Diet GetDiet()
        {
            return Diet;
        }

        public string GetName()
        {
            return Name;
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

        public List<Animal> SpecialFirstSort(List<Animal> animals)
        {


            return animals;
        }
    }
}
