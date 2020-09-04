using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest.FactoryMethod
{
    //惠普鼠标工厂
    public class HpMouseFactory : MouseFactory
    {
        public override Mouse CreateMouse()
        {
            return new HpMouse();//在具体的工厂中实例化产品
        }
    }
}
