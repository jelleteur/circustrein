using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Cart
    {
        public int CartSize;
        public bool ContainsCarnivore;
        public int SizeCarnivore;
        public int SmallestAnimal;

        public Cart()
        {
            CartSize = 10;
            ContainsCarnivore = false;
            SizeCarnivore = 0;
            SmallestAnimal = 10;
        }

        public bool CheckCart(int animalSize)
        {
            if(CartSize - animalSize >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int FillCart(int animalSize) => CartSize -= animalSize;

        public bool AddCarnivore(_Diet diet, _Size size)
        {
            if(diet == _Diet.carnivore)
            {
                ContainsCarnivore = true;
                SizeCarnivore = (int)size;
            }

            return ContainsCarnivore;
        }

    }
}
