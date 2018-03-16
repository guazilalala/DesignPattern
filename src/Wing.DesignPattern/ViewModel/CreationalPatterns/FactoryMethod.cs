using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Wing.DesignPattern.ViewModel.CreationalPatterns
{
	public class FactoryMethodViewModel : ViewModelBase
	{
		public FactoryMethodViewModel()
		{
			Code = System.IO.File.ReadAllText(@"工厂方法模式.cs");
		}
		private string _code;

		public string Code
		{
			get { return _code; }
			set { _code = value; RaisePropertyChanged(() => Code); }
		}
	}
}
