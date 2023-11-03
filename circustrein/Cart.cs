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
        public string AnimalsInside;


        public Cart()
        {
            CartSize = 10;
            ContainsCarnivore = false;
            SizeCarnivore = 0;
            SmallestAnimal = 10;
            AnimalsInside = "";
        }

        public bool CheckCart(int animalSize)
        {
            if (CartSize - animalSize >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int FillCart(int animalSize)
        {
            CartSize = CartSize - animalSize;
            return CartSize;
        }

        public bool AddCarnivore(_Diet diet, _Size size)
        {
            if (diet == _Diet.carnivore)
            {
                ContainsCarnivore = true;
                SizeCarnivore = (int)size;
            }

            return ContainsCarnivore;
        }

        public bool AddToCart(Cart cart, Animal animal)
        {
            cart.FillCart((int)animal.GetSize());
            cart.AnimalsInside = cart.AnimalsInside + animal.GetName() + " ";
            return true;
        }

        public void ShowCartContent(Cart cart)
        {
            Console.WriteLine(cart.AnimalsInside);
        }

        public bool RunThroughCartSpace(Cart cart, Animal animal)
        {
            bool doesFit = cart.CheckCart((int)animal.GetSize());

            bool isCarnivore = animal.IsCarnivore(animal.GetDiet());

            if (doesFit)
            {
                if (cart.ContainsCarnivore && (animal.GetDiet() != _Diet.carnivore))
                {
                    if ((int)animal.GetSize() > cart.SizeCarnivore)
                    {
                        return cart.AddToCart(cart, animal);
                    }
                }
                else if (isCarnivore && !cart.ContainsCarnivore)
                {
                    if (cart.SmallestAnimal >= (int)animal.GetSize())
                    {
                        cart.AddCarnivore(animal.GetDiet(), animal.GetSize());
                        return cart.AddToCart(cart, animal);
                    }

                    else
                    {
                        cart.AddCarnivore(animal.GetDiet(), animal.GetSize());
                        return cart.AddToCart(cart, animal);
                    }

                }
                else if (!isCarnivore && !cart.ContainsCarnivore)
                {
                    return cart.AddToCart(cart, animal);
                }

                else
                {
                    return false;
                }
            }

            return false;
        }
    }
}
