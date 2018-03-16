using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wing.DesignPattern.Model
{
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
}
