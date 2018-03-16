using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 抽象工作模式例子
/// </summary>
namespace Wing.AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
		}
	}

	class AnimalWorld
	{
		private Herbivore _herbivore;
		private Carnivore _carnivore;

		public AnimalWorld(ContinentFactory factory)
		{
			_carnivore = factory.CreateCarbivore();
			_herbivore = factory.CreateHerbivore();
		}
	}

	abstract class ContinentFactory
	{
		public abstract Herbivore CreateHerbivore();
		public abstract Carnivore CreateCarbivore();
	}

	abstract class Carnivore
	{
		public abstract void Eat(Herbivore h);
	}

	abstract class Herbivore
	{
	}

	class Wildebeest : Herbivore
	{

	}

	class Lion : Carnivore
	{
		public override void Eat(Herbivore h)
		{
			throw new NotImplementedException(Herbivore h);
		}
	}
}
