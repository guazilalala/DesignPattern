using ICSharpCode.AvalonEdit.Document;
using System.IO;
using System;

namespace Wing.DesignPattern.ViewModel.CreationalPatterns
{
	public class AbstractFactoryViewModel : DesignPatternViewModelBase
	{
		public AbstractFactoryViewModel()
		{
			Definition = "提供一个创建一系列相关或相互依赖对象的接口，而无须指定它们的具体类。";
			Overview = "Overview";
			ApplicationScenario = $"需要将对象的创建和使用解耦的场合。{Environment.NewLine}且，系统有多个产品族，每次只使用其中一个产品族的产品。{Environment.NewLine}且，产品等级结构稳定，不会增删新旧产品等级结构。";
			Merit = "将一系列具有某种共性的对象统一在一起，使得选择提前。例如软件的皮肤只需要在开始的时候做出选择，之后画方画圆的时候都不需要再考虑选择的问题了。"+
					"高层模块可以方便地通过更换具体工厂来改变所需创建的产品对象类型。具体工厂可以方便地更换想要创建的产品类型。增删产品族十分方便。";
			Defect = "增删产品等级结构十分麻烦。需要产品等级结构足够稳定。解决方案：将结构与行为分离，将产品族和产品等级结构转化为数据结构进行管理。";
			UML = "/Wing.DesignPattern;component/Images/AbstractFactory.gif";
			ExampleCode = new TextDocument(File.ReadAllText("AbstractFactory.cs"));
		}
	}
}
