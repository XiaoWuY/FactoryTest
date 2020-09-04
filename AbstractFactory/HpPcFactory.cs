using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest.AbstractFactory
{
    //惠普pc工厂
    public class HpPcFactory : PcFactory
    {
        public override Mouse CreateMouse()
        {
            return new HpMouse();
        }
        public override Keyboard CreateKeyboard()
        {
            return new HpKeyboard();
        }
    }
}
