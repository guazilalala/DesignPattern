using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Wing.DesignPattern.ViewModel.CreationalPatterns
{
	public class SingletonViewModel : ViewModelBase
	{
		public SingletonViewModel()
		{
		}
		private string _code;

		public string Code
		{
			get { return _code; }
			set { _code = value; RaisePropertyChanged(() => Code); }
		}

		private string _code2;

		public string Code2
		{
			get { return _code2; }
			set { _code2 = value; RaisePropertyChanged(() => Code2); }
		}

		private string _LockSingletonCode;

		public string LockSingletonCode
		{
			get { return _LockSingletonCode; }
			set { _LockSingletonCode = value; RaisePropertyChanged(() => LockSingletonCode); }
		}
	}
}
