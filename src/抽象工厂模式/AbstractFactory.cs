using System;

namespace 抽象工厂模式
{

	public class Client
	{
		static void Main(string[] args)
		{
			//创建奥迪工厂制造汽车
			var audiFactory = new CarFactory<Audi>();
			audiFactory.ProductionCar();

			//创建宝马工厂制造汽车
			var bmwFactory = new CarFactory<BMW>();
			bmwFactory.ProductionCar();

			Console.Read();
		}
	}
	/// <summary>
	/// 客户端接口
	/// </summary>
	public interface ICarFactory
	{
		void ProductionCar();
	}

	/// <summary>
	/// 客户端类
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class CarFactory<T> : ICarFactory where T : IContinentFactory, new()
	{
		ISUV suv;
		ICoupe coupe;
		T factory;

		/// <summary>
		/// 汽车工厂构造方法
		/// </summary>
		public CarFactory()
		{
			//创建一个新的工厂
			factory = new T();

			//造一台SUV
			suv = factory.CreateSUV();

			//造一台轿跑
			coupe = factory.CreateCouper();
		}

		public void ProductionCar()
		{
			suv.Print();
			coupe.Print();
		}
	}

	/// <summary>
	/// 奥迪具体工厂类
	/// </summary>
	public class Audi : IContinentFactory
	{
		public ICoupe CreateCouper()
		{
			return new RS5();
		}

		public ISUV CreateSUV()
		{
			return new Q5();
		}
	}

	/// <summary>
	/// 宝马具体工厂类
	/// </summary>
	public class BMW : IContinentFactory
	{
		public ICoupe CreateCouper()
		{
			return new M3();
		}

		public ISUV CreateSUV()
		{
			return new X3();
		}
	}



	/// <summary>
	/// 抽象工厂
	/// </summary>
	public interface IContinentFactory
	{
		ISUV CreateSUV();
		ICoupe CreateCouper();
	}

	/// <summary>
	/// SUV类抽象产品
	/// </summary>
	public interface ISUV : ICar
	{

	}

	/// <summary>
	/// 轿跑类抽象产品
	/// </summary>
	public interface ICoupe : ICar
	{

	}

	/// <summary>
	/// 汽车
	/// </summary>
	public interface ICar
	{
		void Print();
	}

	/// <summary>
	/// 具体产品Q5
	/// </summary>
	public class Q5 : ISUV
	{
		public void Print()
		{
			Console.WriteLine("奥迪Q5");
		}
	}

	/// <summary>
	/// 具体产品M3
	/// </summary>
	public class M3 : ICoupe
	{
		public void Print()
		{
			Console.WriteLine("宝马M3");
		}
	}

	/// <summary>
	/// 具体产品X3
	/// </summary>
	public class X3 : ISUV
	{
		public void Print()
		{
			Console.WriteLine("宝马X3");
		}
	}

	/// <summary>
	/// 具体产品RS5
	/// </summary>
	public class RS5 : ICoupe
	{
		public void Print()
		{
			Console.WriteLine("奥迪RS5");
		}
	}
}

