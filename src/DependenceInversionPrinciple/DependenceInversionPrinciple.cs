using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependenceInversionPrinciple
{
	public class Client	{
		static void Main(string[] args)
		{
			ICar car = new BmwCar();
			var autoSystem = new AutoSystem(car);
			autoSystem.RunCar();
			Console.Read();
		}
	}
	public class AutoSystem
	{
		private ICar car;
		public AutoSystem(ICar car)
		{
			this.car = car;
		}

		public void RunCar()
		{
			car.Run();
		}
		public void TurnCar()
		{
			car.Turn();
		}

		public void StopCar()
		{
			car.Stop();
		}
	}

	/// <summary>
	/// 汽车接口
	/// </summary>
	public interface ICar
	{
		void Run();
		void Turn();
		void Stop();
	}

	/// <summary>
	/// 宝马车
	/// </summary>
	public class BmwCar : ICar
	{
		public void Run()
		{
			Console.WriteLine("宝马车开始启动了");
		}

		public void Stop()
		{
			Console.WriteLine("宝马车开始停车了");
		}

		public void Turn()
		{
			Console.WriteLine("宝马车开始启动转弯了");
		}
	}

	/// <summary>
	/// 福特车
	/// </summary>
	public class FordCar : ICar
	{
		public void Run()
		{
			Console.WriteLine("福特车开始启动了");
		}

		public void Stop()
		{
			Console.WriteLine("福特车开始停车了");
		}

		public void Turn()
		{
			Console.WriteLine("福特车开始启动转弯了");
		}
	}

	/// <summary>
	/// 本田车
	/// </summary>
	public class HondaCar : ICar
	{
		public void Run()
		{
			Console.WriteLine("本田车开始启动了");
		}

		public void Stop()
		{
			Console.WriteLine("本田车开始停车了");
		}

		public void Turn()
		{
			Console.WriteLine("本田车开始转弯了");
		}
	}

}
