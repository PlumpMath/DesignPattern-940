using SimpleFactory.Pay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.Payment.ConcretePayment
{
    /// <summary>
    /// 具体产品类，将需要创建的各种不同产品对象的相关代码封装到具体产品类中。
    /// </summary>
    public class WechatPay : IPayment
    {
        public void Payment()
        {
            Console.Write("微信付款\n");
        }
    }
}
