using circustrein;
using System.Drawing;

namespace Circustrein.test
{
	public class UnitTest1
	{
		Animal cs = new Animal("cat", _Size.small, _Diet.carnivore);
		Animal cm = new Animal("wolf", _Size.medium, _Diet.carnivore);
		Animal cl = new Animal("tiger", _Size.large, _Diet.carnivore);
		Animal hs = new Animal("rabbit", _Size.small, _Diet.herbivore);
		Animal hm = new Animal("horse", _Size.medium, _Diet.herbivore);
		Animal hl = new Animal("elephant", _Size.large, _Diet.herbivore);




		[Fact]
		public void Test1()
		{
			List<Animal> Animals = new List<Animal>()
			{
				cs, hm, hm, hm, hl, hl
			};

			int MaxLength = 2;

			Sort _Test = new Sort();

			Assert.Equal(MaxLength, _Test.SortList(Animals));
		}

		[Fact]
		public void Test2()
		{
			List<Animal> Animals = new List<Animal>()
			{
				hs, hs, hs, hs, hs, cs, hm, hm, hl
			};

			int MaxLength = 2;

			Sort _Test= new Sort();

			Assert.Equal(MaxLength, _Test.SortList(Animals));
		}

		[Fact]
		public void Test3()
		{
			List<Animal> Animals = new List<Animal>()
			{
				cs, hm, cl, hs, cm, hl
			};

			int MaxLength = 4;

			Sort _Test3 = new Sort();

			//act

			Assert.Equal(MaxLength, _Test3.SortList(Animals));
		}
		
		[Fact]
		public void Test4()
		{
			List<Animal> Animals = new List<Animal>()
			{
				cs, cs, cm, cl, hs, hm, hm, hm, hm, hm, hl, 
			};

			int MaxLength = 5;

			Sort _Test = new Sort();

			Assert.Equal(MaxLength, _Test.SortList(Animals));
		}

		[Fact]
		public void Test5()
		{
			List<Animal> Animals = new List<Animal>()
			{
				cs, hs, hm, hl, hl
			};

			int MaxLength = 2;

			Sort _Test = new Sort();

			Assert.Equal(MaxLength, _Test.SortList(Animals));
		}

		[Fact]
		public void Test6()
		{
			List<Animal> Animals = new List<Animal>()
			{
				hm, hm, cs, cs, hl, hl, hl, cs
			};

			int MaxLength = 3;

			Sort _Test = new Sort();

			Assert.Equal(MaxLength, _Test.SortList(Animals));
		}

		[Fact]
		public void Test7()
		{
			List<Animal> Animals = new List<Animal>()
			{
				cs, cs, cs, cs, cs, cs, cs, cl, cl, cl, cm, cm, cm, hm, hm, hm, hm, hm, hl, hl, hl, hl, hl, hl
			};

			int MaxLength = 13;

			Sort _Test = new Sort();

			Assert.Equal(MaxLength, _Test.SortList(Animals));
		}

		[Fact]
		public void Test8()
		{
			List<Animal> Animals = new List<Animal>()
			{

			};

			int MaxLength = 0;

			Sort _Test = new Sort();

			Assert.Equal(MaxLength, _Test.SortList(Animals));
		}
	}
}