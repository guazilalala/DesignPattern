using GalaSoft.MvvmLight;
using ICSharpCode.AvalonEdit.Document;

namespace Wing.DesignPattern.ViewModel
{
	public abstract class DesignPatternViewModelBase : ViewModelBase
	{
		private string _definition;
		/// <summary>
		/// 定义
		/// </summary>
		public virtual string Definition
		{
			get => _definition; set
			{
				_definition = value;
				RaisePropertyChanged(() => Definition);
			}
		}

		private string _uml;
		/// <summary>
		/// UML类图
		/// </summary>
		public virtual string UML
		{
			get => _uml; set
			{
				_uml = value;
				RaisePropertyChanged(() => UML);
			}
		}

		private string _overview;
		/// <summary>
		/// 概述
		/// </summary>
		public virtual string Overview
		{
			get => _overview; set
			{
				_overview = value;
				RaisePropertyChanged(() => Overview);
			}
		}

		private string _applicationScenario;
		/// <summary>
		/// 应用场景
		/// </summary>
		public virtual string ApplicationScenario
		{
			get => _applicationScenario; set
			{
				_applicationScenario = value;
				RaisePropertyChanged(() => ApplicationScenario);
			}
		}


		private string _merit;

		/// <summary>
		/// 优点
		/// </summary>
		public virtual string Merit
		{
			get => _merit; set
			{
				_merit = value;
				RaisePropertyChanged(() => Merit);
			}
		}

		private string _defect;

		/// <summary>
		/// 缺点
		/// </summary>
		public virtual string Defect
		{
			get => _defect; set
			{
				_defect = value;
				RaisePropertyChanged(() => Defect);
			}
		}

		private TextDocument _exampleCode;

		/// <summary>
		/// 示例代码
		/// </summary>
		public virtual TextDocument ExampleCode
		{
			get => _exampleCode; set
			{
				_exampleCode = value;
				RaisePropertyChanged(() => ExampleCode);
			}
		}
	}
}
