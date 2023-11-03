using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Sort
    {
        public int SortList(List<Animal> Animals)
        {
            List<Cart> Carts = new List<Cart>();
            List<Animal> SpecialAnimals = new List<Animal>();

            //
            Animals = Animals.OrderBy(animal => animal.GetSize()).ToList();
            Animals = Animals.OrderByDescending(animal => animal.GetDiet()).ToList();

            bool SpecialSort = true;
            while (SpecialSort == true)
            {
                foreach (Animal SmallCarnivore in Animals)
                {
                    int AmountOfMidHerbs = 0;
                    if (SmallCarnivore.GetSize() == _Size.small && SmallCarnivore.GetDiet() == _Diet.carnivore)
                    {
                        SpecialAnimals.Add(SmallCarnivore);

                        foreach (Animal MediumHerbivore in Animals)
                        {
                            if (MediumHerbivore.GetSize() == _Size.medium && MediumHerbivore.GetDiet() == _Diet.herbivore && AmountOfMidHerbs != 3)
                            {
                                AmountOfMidHerbs++;
                                SpecialAnimals.Add(MediumHerbivore);
                            }
                        }
                        if (AmountOfMidHerbs != 3)
                        {
                            SpecialSort = false;
                        }

                    }
                }
                if (SpecialAnimals.Count != 4)
                {
                    SpecialSort = false;
                }
                else if (SpecialSort)
                {
                    SpecialAddToCart(Animals, Carts, SpecialAnimals);
                }
            }

            //
            Animals = Animals.OrderByDescending(animal => animal.GetSize()).ToList();
            Animals = Animals.OrderByDescending(animal => animal.GetDiet()).ToList();
            //
            OrderToCarts(Animals, Carts);
            //
            return ShowResults(Carts);
        }

        private static void SpecialAddToCart(List<Animal> Animals, List<Cart> Carts, List<Animal> SpecialAnimals)
        {
            foreach (Animal specialSortAnimals in SpecialAnimals)
            {
                Animals.Remove(specialSortAnimals);
            }
            OrderToCarts(SpecialAnimals, Carts);
            SpecialAnimals.Clear();
        }

        private static void OrderToCarts(List<Animal> Animals, List<Cart> Carts)
        {
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
        }

        private int ShowResults(List<Cart> Carts)
        {
            int TotalCarts = 0;
            foreach (Cart j in Carts)
            {
                TotalCarts++;
            }

            foreach (Cart carts in Carts)
            {
                carts.ShowCartContent(carts);
            }
            Console.WriteLine("Amount of carts needed: " + TotalCarts);

            return TotalCarts;
        }
    }
}
