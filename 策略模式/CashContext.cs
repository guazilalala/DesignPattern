using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public class CashContext
    {
        private CashSuper cs = null;

        /// <summary>
        /// 通过构造方法，传入具体的收费策略
        /// </summary>
        /// <param name="cashSuper"></param>
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    CashNormal cs0 = new CashNormal();
                    cs = cs0;
                    break;
                case "满300返100":
                    CashReturn cr1 = new CashReturn("300", "100");
                    cs = cr1;
                    break;
                case "打8折":
                    CashRebate cr2 = new CashRebate("0.8");
                    cs = cr2;
                    break;
            }
        }

        /// <summary>
        /// 根据收费策略的不同，获得计算结果
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }


    }
}
