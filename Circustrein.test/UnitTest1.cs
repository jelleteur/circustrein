using circustrein;
using System.Drawing;

namespace Circustrein.test
{
	public class UnitTest1
	{
		Animal cs = new Animal(_Size.small, _Diet.carnivore);
		Animal cm = new Animal(_Size.medium, _Diet.carnivore);
		Animal cl = new Animal(_Size.large, _Diet.carnivore);
		Animal hs = new Animal(_Size.small, _Diet.herbivore);
		Animal hm = new Animal(_Size.medium, _Diet.herbivore);
		Animal hl = new Animal(_Size.large, _Diet.herbivore);




		[Fact]
		public void Test1()
		{
			List<Animal> Animals = new List<Animal>()
			{
				cs, hm, hm, hm, hl, hl
			};

			int MaxLength = 2;

			TestIt _Test = new TestIt();

			Assert.Equal(MaxLength, _Test.TrainLength(Animals));
		}

		[Fact]
		public void Test2()
		{
			List<Animal> Animals = new List<Animal>()
			{
				hs, hs, hs, hs, hs, cs, hm, hm, hl
			};

			int MaxLength = 2;

			TestIt _Test= new TestIt();

			Assert.Equal(MaxLength, _Test.TrainLength(Animals));
		}

		[Fact]
		public void Test3()
		{
			List<Animal> Animals = new List<Animal>()
			{
				cs, hm, cl, hs, cm, hl
			};

			int MaxLength = 4;

			TestIt _Test3 = new TestIt();

			Assert.Equal(MaxLength, _Test3.TrainLength(Animals));
		}
		
		[Fact]
		public void Test4()
		{
			List<Animal> Animals = new List<Animal>()
			{
				cs, cs, cm, cl, hs, hm, hm, hm, hm, hm, hl, 
			};

			int MaxLength = 5;

			TestIt _Test = new TestIt();

			Assert.Equal(MaxLength, _Test.TrainLength(Animals));
		}

		[Fact]
		public void Test5()
		{
			List<Animal> Animals = new List<Animal>()
			{
				cs, hs, hm, hl, hl
			};

			int MaxLength = 2;

			TestIt _Test = new TestIt();

			Assert.Equal(MaxLength, _Test.TrainLength(Animals));
		}

		[Fact]
		public void Test6()
		{
			List<Animal> Animals = new List<Animal>()
			{
				hm, hm, cs, cs, hl, hl, hl, cs
			};

			int MaxLength = 3;

			TestIt _Test = new TestIt();

			Assert.Equal(MaxLength, _Test.TrainLength(Animals));
		}

		[Fact]
		public void Test7()
		{
			List<Animal> Animals = new List<Animal>()
			{
				cs, cs, cs, cs, cs, cs, cs, cl, cl, cl, cm, cm, cm, hm, hm, hm, hm, hm, hl, hl, hl, hl, hl, hl
			};

			int MaxLength = 13;

			TestIt _Test = new TestIt();

			Assert.Equal(MaxLength, _Test.TrainLength(Animals));
		}

		[Fact]
		public void Test8()
		{
			List<Animal> Animals = new List<Animal>()
			{

			};

			int MaxLength = 0;

			TestIt _Test = new TestIt();

			Assert.Equal(MaxLength, _Test.TrainLength(Animals));
		}
	}
}