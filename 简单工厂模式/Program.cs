using System;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("请输入数字A：");
            string strNumberA = Console.ReadLine();
            Console.Write("请选择运算符号(+、-、*、/)：");
            string strOperate = Console.ReadLine();
            Console.Write("请输入数字B：");
            string strNumberB = Console.ReadLine();
            string strResult = "";
            Operation oper;
            oper = OperationFactory.createOperate(strOperate);
            oper.NumberA = Convert.ToDouble(strNumberA);
            oper.NumberB = Convert.ToDouble(strNumberB);
            strResult = oper.GetResult().ToString();
            System.Console.WriteLine(strResult);

            Console.Read();
        }
    }
}
