using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 返利收费子类
    /// </summary>
    public class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        /// <summary>
        /// 反利收费，初始化时必须要输入返利条件和返利值 ，比如满300返100则moneyCondition为300，moneyReturn为100
        /// </summary>
        /// <param name="moneyCondition">返利条件</param>
        /// <param name="moneyReturn">返利值</param>
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }


        public override double acceptCash(double money)
        {
            double result = money;

            //若大于返利条件，则需要减去返利值
            if (money >= moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }

            return result;
        }
    }
}
