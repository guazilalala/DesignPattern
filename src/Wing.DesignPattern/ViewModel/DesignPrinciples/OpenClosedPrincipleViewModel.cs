using ICSharpCode.AvalonEdit.Document;
using System.Text;
using System;
namespace Wing.DesignPattern.ViewModel.CreationalPatterns
{
	public class OpenClosedPrincipleViewModel : DesignPrinciplesViewModelBase
	{
		public OpenClosedPrincipleViewModel()
		{
			Concepts = new StringBuilder()
				.Append(Bullet).Append("开放-封闭原则，是说软件实体(类、模块、函数等等)应该可以扩展，但是不可修改。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("开放-封闭原则（OCP）是面向对象设计中“可复用设计”的基石，是面向对象设计中最重要的原则之一，其它很多的设计原则都是实现开闭原则的一种手段。对于扩展是开放的，对于修改是关闭的，这意味着模块的行为是可以扩展的。当应用的需求改变时，我们可以对模块进行扩展，使其具有满足那些改变的新行为。也就是说，我们可以改变模块的功能。对模块行为进行扩展时，不必改动模块的源代码或者二进制代码。模块的二进制可执行版本，无论是可链接的库、DLL或者.EXE文件，都无需改动。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("是面向对象设计的核心所在。遵循这个原则可以带来面向对象技术所声称的巨大好处，也就是可维护、可扩展、可复用、灵活性好。开发人员应该仅对程序中呈现频繁变化的那些部分做出抽象，然而，对于应用程序中的每个部分都刻意地进行抽象同样不是一个好主意。拒绝不成熟的抽象和抽象本身一样的重要。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("实现开闭原则的关键就在于“抽象”。把系统的所有可能的行为抽象成一个抽象底层，这个抽象底层规定出所有的具体实现必须提供的方法的特征。作为系统设计的抽象层，要预见所有可能的扩展，从而使得在任何扩展情况下，系统的抽象底层不需修改；同时，由于可以从抽象底层导出一个或多个新的具体实现，可以改变系统的行为，因此系统设计对扩展是开放的。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("如何使用开原则:通过接口或者抽象类约束扩展，对扩展进行边界限定，不允许出现在接口或抽象类中不存在的public方法；参数类型、引用对象尽量使用接口或者抽象类，而不是实现类；抽象层尽量保持稳定，一旦确定即不允许修改。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("开放-封闭原则的好处:可复用性好，我们可以在软件完成以后，仍然可以对软件进行扩展，加入新的功能，非常灵活。因此，这个软件系统就可以通过不断地增加新的组件，来满足不断变化的需求；可维护性好，由于对于已有的软件系统的组件，特别是它的抽象底层不去修改，因此，我们不用担心软件系统中原有组件的稳定性，这就使变化中的软件系统有一定的稳定性和延续性。")
				.ToString();

			UML = "/Wing.DesignPattern;component/Images/OpenClosedPrinciple.jpg";
			ExampleCode = new TextDocument(GetCode("OpenClosedPrinciple.cs"));
		}
	}
}
