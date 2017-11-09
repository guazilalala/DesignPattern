namespace 简单工厂模式
{
    public abstract class Operation
    {
        public double NumberA {get;set;}
        public double NumberB{get;set;}
        public virtual double GetResult()
        {
            double result =0;

            return result;
        }

    }
}