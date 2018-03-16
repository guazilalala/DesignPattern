using System;

namespace Wing.DesignPattern.Model
{
	/// <summary>
	/// Singleton类
	/// </summary>
	public sealed class Singleton2  //sealed阻止发生派生，而派生可能会增加实例
	{
		/// <summary>
		/// 在第一次引用类的任何成员时创建实例。公共语言运行库负责处理变量初始化
		/// </summary>
		private static readonly Singleton2 _instance = new Singleton2();
		private Singleton2()
		{
		}
		public static Singleton2 GetInstance()
		{
			return _instance;
		}
	}
}
