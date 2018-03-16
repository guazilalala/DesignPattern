using System;

namespace 工厂方法模式
{
	class Client
	{
		static void Main(string[] args)
		{
			Creator shreddedPorkWithPotatoesFactory = new ShreaddedPorkWithPotatoesFactory();
			Creator tomatoScrambledEggsFactory = new TomatoScrambledEggsFactory();

			// 开始做西红柿炒蛋
			Food tomatoScrambleEggs = tomatoScrambledEggsFactory.CreateFoodFactory();
			tomatoScrambleEggs.Print();

			//开始做土豆肉丝
			Food shreddedPorkWithPotatoes = shreddedPorkWithPotatoesFactory.CreateFoodFactory();
			shreddedPorkWithPotatoes.Print();

			Console.Read();
		}
	}

	/// <summary>
	/// 菜抽象
	/// </summary>
	public abstract class Food
	{
		/// <summary>
		/// 输出点什么菜
		/// </summary>
		public abstract void Print();
	}

	/// <summary>
	/// 西红柿炒鸡蛋这道菜
	/// </summary>
	public class TomatoScrambledEggs : Food
	{
		public override void Print()
		{
			Console.WriteLine("西红柿炒蛋好了！");
		}
	}

	/// <summary>
	/// 土豆肉丝这道菜
	/// </summary>
	public class ShreddedPorkWithPotatoes : Food
	{
		public override void Print()
		{
			Console.WriteLine("土豆肉丝好了");
		}
	}

	/// <summary>
	/// 抽象工厂类
	/// </summary>
	public abstract class Creator
	{
		/// <summary>
		/// 工厂方法
		/// </summary>
		/// <returns></returns>
		public abstract Food CreateFoodFactory();
	}

	/// <summary>
	/// 西红柿炒蛋工厂类
	/// </summary>
	public class TomatoScrambledEggsFactory : Creator
	{
		public override Food CreateFoodFactory()
		{
			return new TomatoScrambledEggs();
		}
	}

	/// <summary>
	/// 土豆肉丝工厂类
	/// </summary>
	public class ShreaddedPorkWithPotatoesFactory : Creator
	{
		public override Food CreateFoodFactory()
		{
			return new ShreddedPorkWithPotatoes();
		}
	}
}
