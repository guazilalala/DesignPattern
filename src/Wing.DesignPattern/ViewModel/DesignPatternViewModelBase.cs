using GalaSoft.MvvmLight;
using ICSharpCode.AvalonEdit.Document;
using System.IO;
namespace Wing.DesignPattern.ViewModel
{
	public abstract class DesignPrinciplesViewModelBase : ViewModelBase
	{
		/// <summary>
		/// 项目符号
		/// </summary>
		public readonly string Bullet = " • ";
		private string _concepts;
		/// <summary>
		/// 概念
		/// </summary>
		public virtual string Concepts
		{
			get => _concepts; set
			{
				_concepts = value;
				RaisePropertyChanged(() => Concepts);
			}
		}
		private TextDocument _exampleCode;

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

		/// <summary>
		/// 读取代码文件,返回字符串
		/// </summary>
		/// <param name="path">文件路径</param>
		/// <returns></returns>
		public virtual string GetCode(string path)
		{
			if (File.Exists(path))
			{
				return File.ReadAllText(path);
			}
			return string.Empty;
		}
	}
}
