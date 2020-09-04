using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest.FactoryMethod
{
    //戴尔鼠标工厂
    public class DellMouseFactroy : MouseFactory
    {
        public override Mouse CreateMouse()
        {
            return new DellMouse();//在具体的工厂中实例化产品
        }
    }
}
