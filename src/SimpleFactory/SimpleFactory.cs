/*
运算操作 
 */
using System;

namespace SimpleFactory
{
	/// <summary>
	/// 客户端
	/// </summary>
	class Client
	{
		static void Main(string[] args)
		{
			Operation oper = OperationFactory.CreateOperate("+");
			oper.NumberA = 1;
			oper.NumberB = 2;
			double result = oper.GetResult();

			Console.WriteLine(result);
			Console.Read();
		}
	}

	/// <summary>
	/// 运算类
	/// </summary>
	public abstract class Operation
	{
		public double NumberA { get; set; }
		public double NumberB { get; set; }

		public virtual double GetResult()
		{
			const double result = 0;
			return result;
		}
	}

	/// <summary>
	/// 简单工厂类
	/// </summary>
	public class OperationFactory
	{
		public static Operation CreateOperate(string operate)
		{
			Operation operation = null;

			switch (operate)
			{
				case "+":
					operation = new Plus();
					break;
				case "-":
					operation = new Minus();
					break;
				case "*":
					operation = new Multiply();
					break;
				case "/":
					operation = new Divide();
					break;
			}
			return operation;
		}
	}

	/// <summary>
	/// 加运算类
	/// </summary>
	public class Plus : Operation
	{
		public override double GetResult()
		{
			return NumberA + NumberB;
		}
	}

	/// <summary>
	/// 减运算类
	/// </summary>
	public class Minus : Operation
	{
		public override double GetResult()
		{
			return NumberA - NumberB;
		}
	}

	/// <summary>
	/// 乘运算类
	/// </summary>
	public class Multiply : Operation
	{
		public override double GetResult()
		{
			return NumberA * NumberB;
		}
	}

	/// <summary>
	/// 除运算类
	/// </summary>
	public class Divide : Operation
	{
		public override double GetResult()
		{
			return NumberA / NumberB;
		}
	}

}
