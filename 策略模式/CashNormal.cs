using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 正常收费子类
    /// </summary>
    public class CashNormal : CashSuper
    {
        /// <summary>
        /// 正常收费，原价返回
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
