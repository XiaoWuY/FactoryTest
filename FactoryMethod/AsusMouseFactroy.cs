using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest.FactoryMethod
{
    //华硕鼠标工厂
    public class AsusMouseFactroy : MouseFactory
    {
        public override Mouse CreateMouse()
        {
            return new AsusMouse();//在具体的工厂中实例化产品
        }
    }
}
