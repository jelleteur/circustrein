using circustrein;
using System.Diagnostics;

int TrainLength(List<Animal> Animals)
{
    List<Cart> Carts = new List<Cart>();


    Animals = Animals.OrderBy(animal => animal.Size).ToList();

    List<Animal> TempAnimal = new List<Animal>();

    foreach (Animal a in Animals)
    {
        bool addedToCart = false;
        while (!addedToCart)
        {
            foreach (Cart c in Carts)
            {
                bool doesFit = c.CheckCart((int)a.GetSize());

                bool isCarnivore = a.IsCarnivore(a.Diet);

                if (doesFit)
                {
                    bool containsCarnivore = c.ContainsCarnivore;

                    if (c.ContainsCarnivore && (a.Diet != _Diet.carnivore))
                    {
                        if ((int)a.GetSize() > c.SizeCarnivore)
                        {
                            c.FillCart((int)a.GetSize());
                            Console.WriteLine(c.CartSize);
                            TempAnimal.Add(a);
                            addedToCart = true;
                            break;
                        }
                    }
                    else if (isCarnivore && !containsCarnivore)
                    {
                        if (c.SmallestAnimal <= (int)a.Size)
                        {
                            c.AddCarnivore(a.Diet, a.Size);
                            c.FillCart((int)a.GetSize());
                            Console.WriteLine(c.CartSize);
                            TempAnimal.Add(a);
                            addedToCart = true;
                            break;
                        }

                    }
                    else
                    {
                        c.FillCart((int)a.GetSize());
                        Console.WriteLine(c.CartSize);
                        TempAnimal.Add(a);
                        addedToCart = true;
                        break;
                    }
                }
            }

            if (!addedToCart)
            {
                Cart newCart = new Cart();
                Carts.Add(newCart);
                // newCart.FillCart((int)a.GetSize());
                // Console.WriteLine(newCart.CartSize);
                //TempAnimal.Add(a);
            }
        }
    }

    // Remove the marked animals from the Animals list
    foreach (Animal a in TempAnimal)
    {
        Animals.Remove(a);
    }



    int TotalCarts = 0;
    foreach (Cart j in Carts)
    {
        TotalCarts++;
    }

   /* Console.WriteLine("Final amount of needed carts: " + TotalCarts);
    if (TotalCarts <= train.TrainLength)
    {
        Console.WriteLine("Scenario succesful");
    }
    else
    {
        Console.WriteLine("Scenario failed");
    }*/

    return TotalCarts;
}


//(int)Animal.GetSize();

/*
 * Sen1
 * new Animal(_Size.small, _Diet.carnivore),
    new Animal(_Size.large, _Diet.herbivore),
    new Animal(_Size.medium, _Diet.herbivore),
    new Animal(_Size.medium, _Diet.herbivore),
    new Animal(_Size.large, _Diet.herbivore),
    new Animal(_Size.medium, _Diet.herbivore)
 * 
 * Sen2
 * new Animal(_Size.small, _Diet.carnivore),
    new Animal(_Size.large, _Diet.herbivore),
    new Animal(_Size.medium, _Diet.herbivore),
    new Animal(_Size.small, _Diet.herbivore),
    new Animal(_Size.small, _Diet.herbivore),
    new Animal(_Size.small, _Diet.herbivore),
    new Animal(_Size.small, _Diet.herbivore),
    new Animal(_Size.small, _Diet.herbivore),
    new Animal(_Size.medium, _Diet.herbivore)
 * 
 * Sen3
 * 
 * 
 * Sen4
 * 
 * 
 * Sen5
 * 
 * 
 * Sen6
 * 
 * 
 * Sen7
 * 
 */