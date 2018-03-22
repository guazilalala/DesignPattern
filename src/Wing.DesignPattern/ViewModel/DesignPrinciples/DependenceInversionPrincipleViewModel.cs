using ICSharpCode.AvalonEdit.Document;
using System.Text;
using System;
namespace Wing.DesignPattern.ViewModel.CreationalPatterns
{
	public class DependenceInversionPrincipleViewModel : DesignPrinciplesViewModelBase
	{
		public DependenceInversionPrincipleViewModel()
		{
			Concepts = new StringBuilder()
				.Append(Bullet).Append("高层次的模块不应该依赖于低层次的模块，他们都应该依赖于抽象。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("抽象不应该依赖于具体实现，具体实现应该依赖于抽象。")

				.ToString();

			UML = "/Wing.DesignPattern;component/Images/DependenceInversionPrinciple.jpg";

			ExampleCode = new TextDocument(GetCode("DependenceInversionPrinciple.cs"));
		}
	}
}
