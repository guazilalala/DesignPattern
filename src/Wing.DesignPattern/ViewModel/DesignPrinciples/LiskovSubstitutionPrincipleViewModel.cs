using ICSharpCode.AvalonEdit.Document;
using System;
using System.Text;

namespace Wing.DesignPattern.ViewModel.CreationalPatterns
{
	public class LiskovSubstitutionPrincipleViewModel : DesignPrinciplesViewModelBase
	{
		public LiskovSubstitutionPrincipleViewModel()
		{
			Concepts = new StringBuilder()
				.Append(Bullet).Append("里氏代换原则（LSP）：子类型必须能够替换掉它们的父类型。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("里氏替换原则针对的对象是具有继承关系的子类和父类。")
				.Append(Environment.NewLine)
				.Append("").ToString();

			ExampleCode = new TextDocument(GetCode(""));
		}
	}
}
