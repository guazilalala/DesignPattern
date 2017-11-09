using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 现金收费抽象类
    /// </summary>
    public abstract class CashSuper
    {

        /// <summary>
        ///  现金收取超类的抽象方法，收取现金。
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns>当前价</returns>
        public abstract double acceptCash(double money);
    }
}
