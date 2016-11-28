using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.Pay
{
    /// <summary>
    /// 抽象产品类，将具体产品类公共的代码进行抽象和提取后封装在一个抽象产品类中。
    /// </summary>
    public interface IPayment
    {
        void Payment();
    }
}
