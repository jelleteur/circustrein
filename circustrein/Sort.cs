using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Sort
    {
        public int SortList(List<Animal> Animals)
        {
            List<Cart> Carts = new List<Cart>();
            List<Animal> SpecialAnimal = new List<Animal>();
            //
            Animals = Animals.OrderByDescending(animal => animal.Size).ToList();
            Animals = Animals.OrderByDescending(animal => animal.Diet).ToList();
            //
            foreach (Animal animal in Animals)
            {
                bool addedToCart = false;
                while (!addedToCart)
                {
                    foreach (Cart cart in Carts)
                    {
                        addedToCart = cart.RunThroughCartSpace(cart, animal);
                        if (addedToCart)
                        {
                            break;
                        }
                    }

                    if (!addedToCart)
                    {
                        Cart newCart = new Cart();
                        Carts.Add(newCart);
                    }
                }

            }
            //
            int TotalCarts = 0;
            foreach (Cart j in Carts)
            {
                TotalCarts++;
            }

            foreach (Cart carts in Carts)
            {
                carts.ShowCartContent(carts);
                Console.WriteLine("Amount of carts needed: " + TotalCarts);
            }

            return TotalCarts;
        }

    }
}
