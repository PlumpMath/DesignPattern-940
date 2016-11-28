using SimpleFactory.Pay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("============简单工厂模式============\n");
            IPayment iPayment = Factory.CreatePayment("AliPay");
            iPayment.Payment();
            iPayment = Factory.CreatePayment("WechatPay");
            iPayment.Payment();
        }
    }
}
