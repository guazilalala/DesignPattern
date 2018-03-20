using ICSharpCode.AvalonEdit.Document;
using System;
using System.Text;

namespace Wing.DesignPattern.ViewModel.CreationalPatterns
{
	public class SimpleFactoryViewModel : DesignPatternViewModelBase
	{
		public SimpleFactoryViewModel()
		{
			Definition = new StringBuilder()
				.Append(Bullet).Append("简单工厂模式定义一个Factory类，可以根据参数的不同返回不同类的实例，被创建的实例通常有共同的父类。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("简单工厂模式只需要一个Factory类。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("简单工厂模式又称为静态工厂模式，Factory类为静态类或包含静态方法。")
				.ToString();

			Participants = new StringBuilder()
				.Append(Bullet).Append("Product：抽象产品类，将具体产品类公共的代码进行抽象和提取后封装在一个抽象产品类中。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("ConcreteProduct：具体产品类，将需要创建的各种不同产品对象的相关代码封装到具体产品类中。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("Factory：工厂类，提供一个工厂类用于创建各种产品，在工厂类中提供一个创建产品的工厂方法，该方法可以根据所传入参数的不同创建不同的具体产品对象。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("Client：客户端类，只需调用工厂类的工厂方法并传入相应的参数即可得到一个产品对象。")
				.ToString();

			UML = "/Wing.DesignPattern;component/Images/SimpleFactory.jpg";

			Merit = new StringBuilder()
				.Append(Bullet).Append("实现了创建和使用分离；")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("Client无需知道所创建的ConcreteProduct类名，只需要知道ConcreteProduct所对应的参数。")
				.ToString();

			Defect = new StringBuilder()
				.Append(Bullet).Append("Factory类集中了所有ConcreteProduct的创建逻辑，职责过重。一旦需要添加新的ConcreteProduct，则需要修改Factory逻辑。这样违背了OCP（开放-关闭原则）。")
				.Append(Environment.NewLine)
				.Append(Bullet).Append("由于使用了static方法，造成Factory无法形成基于继承的结构。")
				.ToString();
			ExampleCode = new TextDocument(GetCode("SimpleFactory.cs"));

		}
	}
} 
