using System;

namespace Wing.DesignPattern.Model
{
	/// <summary>
	/// Singleton类
	/// </summary>
	public class Singleton
	{
		private static Singleton _instance;
		/// <summary>
		/// 构造方法让其private,这就堵死了外界利用new 创建些类实例的可能 
		/// </summary>
		private Singleton()
		{
		}

		/// <summary>
		/// 此方法是获得本类实例的唯一全局访问点
		/// </summary>
		/// <returns></returns>
		public static Singleton GetInstance()
		{
			//若实例不存在，则new 一个新实例，否则返回已有的实例
			if (_instance == null)
			{
				_instance = new Singleton();
			}
			return _instance;
		}
	}

	/// <summary>
	/// 客户端代码
	/// </summary>
	public class Program
	{
		static void Client(string[] args)
		{
			Singleton s1 = Singleton.GetInstance();
			Singleton s2 = Singleton.GetInstance();

			if (s1 == s2) //比较两次实例化后对象的结果是实例相同
			{
				Console.WriteLine("两个对象是相同的实例");
			}

			Console.Read();
		}
	}
}
