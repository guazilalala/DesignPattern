using ICSharpCode.AvalonEdit.Document;
using System.Text;
using System;
namespace Wing.DesignPattern.ViewModel.CreationalPatterns
{
	public class SingleResponsibilityPrincipleViewModel : DesignPrinciplesViewModelBase
	{
		public SingleResponsibilityPrincipleViewModel()
		{
			Concepts = new StringBuilder()
				.Append(Bullet).Append("单一职责原则（SRP）,就一个类而言，应该仅有一个引起它变化的原因。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("如果一个类承担的职责过多，就等于把这些职责耦合在一起，一个职责的变化可能会削弱或者抑制这个类完成其他职责的能力。这种耦合会导致脆弱的设计，当变化发生时，设计会遭受到意想不到的破坏。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("单一职责原则的定义是：应该有且只有一个原因引起类的改变，即一个类只负责一个职责。比如让类C负责两个不同的职责：职责P1，P2。当由于职责P1需求发生改变而需要修改类C时，有可能会导致原本运行正常的职责P2功能发生故障。").ToString();


			ExampleCode = new TextDocument(GetCode(""));
		}
	}
}
