using System;

namespace Wing.DesignPattern.Model
{
	public class LockSingleton
	{
		private static LockSingleton _instance;
		/// <summary>
		/// 程序运行时创建一个静态只读的进程辅助对象
		/// </summary>
		private static readonly object syncRoot = new object();
		private LockSingleton()
		{
		}

		public static LockSingleton GetInstance()
		{
			lock (syncRoot) //在同一个时刻加了锁的那部分程序只有一个线程可以进入
			{
				if (_instance == null)
				{
					_instance = new LockSingleton();
				}
			}
			return _instance;
		}
	}

	/// <summary>
	/// 双重锁定
	/// </summary>
	public class DoubleLockSingleton
	{
		private static DoubleLockSingleton _doubleLockSingleton;
		private static readonly object syncRoot = new object();
		private DoubleLockSingleton()
		{
		}

		public DoubleLockSingleton GetInstance()
		{
			if (_doubleLockSingleton == null) //先判断实例是否存在，不存在再加锁处理
			{
				lock (syncRoot)
				{
					if (_doubleLockSingleton == null)
					{
						return new DoubleLockSingleton();
					}
				}
			}
			return _doubleLockSingleton;
		}
	}
}
