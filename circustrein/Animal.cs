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
        //public string Name { get; set; }
        public _Size Size { get; set; }
        public _Diet Diet { get; set; }

        public Animal(_Size size, _Diet diet)
        {
            Size = size;
            Diet = diet;
        }

        public _Size GetSize() => Size;

        public bool IsCarnivore(_Diet diet)
        {
            if(diet == _Diet.carnivore)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{Size} {Diet}";
        }



        /*private int PickSize(int size)
        {
            int smallValue = 1;
            int mediumValue = 3;
            int largeValue = 5;
            int errorSize = 11;

            if (size == Convert.ToInt32(_Size.small))
            {
                return smallValue;
            }
            else if (size == Convert.ToInt32(_Size.medium))
            {
                return mediumValue;
            }
            else if (size == Convert.ToInt32(_Size.large))
            {
                return largeValue;
            }
            else
            {
                return errorSize;
            }
        }

        private int PickDiet(int diet)
        {
            int carnivore = 0;
            int herbivore = 1;

            if (diet == Convert.ToInt32(_Diet.carnivore))
            {
                return carnivore;
            }
            else
            {
                return herbivore;
            }
        }*/
    }
}
