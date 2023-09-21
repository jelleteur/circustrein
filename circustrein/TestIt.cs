using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
	public class TestIt
	{
		public int TrainLength(List<Animal> Animals)
		{
			List<Cart> Carts = new List<Cart>();


			Animals = Animals.OrderByDescending(animal => animal.Size).ToList();
			Animals = Animals.OrderByDescending(animal => animal.Diet).ToList();

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
							else if (isCarnivore && !c.ContainsCarnivore)
							{
								if (c.SmallestAnimal >= (int)a.Size)
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
					}
				}
			}

			foreach (Animal a in TempAnimal)
			{
				Animals.Remove(a);
			}

			int TotalCarts = 0;
			foreach (Cart j in Carts)
			{
				TotalCarts++;
			}

			return TotalCarts;
		}

	}
}
