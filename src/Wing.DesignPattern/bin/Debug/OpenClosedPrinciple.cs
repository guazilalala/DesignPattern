using System;

namespace OpenClosedPrinciple
{
	class OpenClosedPrinciple
	{
		static void Main(string[] args)
		{
		}
	}
	/// <summary>
	/// 形状
	/// </summary>
	public abstract class Shape
	{
		/// <summary>
		/// 名称
		/// </summary>
		protected string _name;
		protected Shape(string name)
		{
			_name = name;
		}

		/// <summary>
		/// 面积
		/// </summary>
		/// <returns></returns>
		public abstract double Area();

		/// <summary>
		/// 显示
		/// </summary>
		public abstract void Display();
	}

	/// <summary>
	/// 长方形
	/// </summary>
	public class Rectangle : Shape
	{
		private double _width;
		private double _height;

		public Rectangle(string name,double width,double height) : base(name)
		{
			_width = width;
			_height = height;
		}

		public override double Area()
		{
			return _width * _height;
		}

		public override void Display()
		{
			Console.WriteLine($"{_name} 长：{_width}，宽：{_height}，面积：{Area()}");
		}
	}

	/// <summary>
	/// 圆形
	/// </summary>
	public class Circle : Shape
	{
		/// <summary>
		/// 半径
		/// </summary>
		private double _radius;
		public Circle(string name, double radius) : base(name)
		{
			_radius = radius;
		}

		public override double Area()
		{
			return Math.Round(Math.PI * _radius * _radius, 2);
		}

		public override void Display()
		{
			Console.WriteLine($"{_name} 半径：{_radius}，面积：{this.Area()}");
		}
	}
}
