using System;
namespace 抽象工厂模式
{
	/// <summary>
	/// 下面以绝味鸭脖连锁店为例子演示下抽象工厂模式
	/// 因为每个地方的喜欢的口味不一样，有些地方喜欢辣点的，有些地方喜欢吃不辣点
	/// 客户端调用
	/// </summary>
	class Client2
	{
		static void Main2(string[] args)
		{
			// 南昌工厂制作南昌的鸭脖和鸭架
			AbstractFactory nanChangFactory = new NanChangFactory();
			YaBo nanChangYaBo = nanChangFactory.CreateYaBo();
			nanChangYaBo.Print();
			YaJia nanChangYajia = nanChangFactory.CreateYaJia();
			nanChangYajia.Print();

			// 上海工厂制作南昌的鸭脖和鸭架
			AbstractFactory shangHaiFactory = new ShangHaiFactory();
			shangHaiFactory.CreateYaBo().Print();
			shangHaiFactory.CreateYaJia().Print();


			AbstractFactory guangDongFactory = new GuangDongFactory();
			guangDongFactory.CreateYaBo().Print();
			guangDongFactory.CreateYaJia().Print();

			Console.Read();
		}
	}

	/// <summary>
	/// 抽象工厂类，提供创建两个不同地方的鸭架和鸭脖的接口
	/// </summary>
	public abstract class AbstractFactory
	{
		//抽象工厂提供创建一系列产品的接口，这里作为例子，只给出了绝味中鸭脖和鸭架的创建接口
		public abstract YaBo CreateYaBo();
		public abstract YaJia CreateYaJia();
	}

	/// <summary>
	///  南昌绝味工厂负责制作南昌的鸭脖和鸭架
	/// </summary>
	public class NanChangFactory : AbstractFactory
	{
		public override YaBo CreateYaBo()
		{
			return new NanChangYaBO();
		}

		public override YaJia CreateYaJia()
		{
			return new NanChangYaJia();
		}
	}

	/// <summary>
	///  上海绝味工厂负责制作南昌的鸭脖和鸭架
	/// </summary>
	public class ShangHaiFactory : AbstractFactory
	{
		public override YaBo CreateYaBo()
		{
			return new ShangHaiYaBo();
		}

		public override YaJia CreateYaJia()
		{
			return new ShangHaiYaJia();
		}
	}

	public class GuangDongFactory : AbstractFactory
	{
		public override YaBo CreateYaBo()
		{
			return new GuangDongYaBo();
		}

		public override YaJia CreateYaJia()
		{
			return new GuangDongYaJia();
		}
	}

	public abstract class YaBo
	{
		public abstract void Print();
	}
	public abstract class YaJia
	{
		public abstract void Print();
	}

	/// <summary>
	/// 上海的鸭脖
	/// </summary>
	public class ShangHaiYaBo : YaBo
	{
		public override void Print()
		{
			System.Console.WriteLine("上海的鸭脖");
		}
	}

	/// <summary>
	/// 南昌的鸭脖
	/// </summary>
	public class NanChangYaBO : YaBo
	{
		public override void Print()
		{
			Console.WriteLine("南昌的鸭脖");
		}
	}

	/// <summary>
	///上海的鸭架
	/// </summary>
	public class ShangHaiYaJia : YaJia
	{
		public override void Print()
		{
			Console.WriteLine("上海的鸭架");
		}
	}

	/// <summary>
	/// 南昌鸭架
	/// </summary>
	public class NanChangYaJia : YaJia
	{
		public override void Print()
		{
			System.Console.WriteLine("南昌的鸭架");
		}
	}

	/// <summary>
	///广东鸭架
	/// </summary>
	public class GuangDongYaBo : YaBo
	{
		public override void Print()
		{
			Console.WriteLine("广东鸭脖");
		}
	}

	/// <summary>
	/// 广东鸭架
	/// </summary>
	public class GuangDongYaJia : YaJia
	{
		public override void Print()
		{
			System.Console.WriteLine("广东鸭架");
		}
	}
}
