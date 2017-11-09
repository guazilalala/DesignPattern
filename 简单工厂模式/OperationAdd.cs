namespace 简单工厂模式
{
    public class OperationAdd:Operation
    {
        public override double GetResult()
        {
            double result = 0;

            result = NumberA + NumberB;
            return result;
        }
    }
}