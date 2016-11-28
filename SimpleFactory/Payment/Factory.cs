using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.Pay
{
    public class Factory
    {
        /// <summary>
        /// 工厂类,提供一个工厂类用于创建各种产品，在工厂类中提供一个创建产品的工厂方法，该方法可以根据所传入参数的不同创建不同的具体产品对象。
        /// </summary>
        /// <param name="pay"></param>
        /// <returns></returns>
        public static IPayment CreatePayment(string pay)
        {
            IPayment payment = null;
            switch (pay)
            {
                case "AliPay":
                    payment = new Payment.ConcretePayment.AliPay();
                    break;
                case "WechatPay":
                    payment = new Payment.ConcretePayment.WechatPay();
                    break;
            }
            return payment;
        }
    }
}
