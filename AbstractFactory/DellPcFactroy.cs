using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest.AbstractFactory
{
    //戴尔pc工厂
    public class DellPcFactroy : PcFactory
    {
        public override Keyboard CreateKeyboard()
        {
            return new DellKeyboard();
        }

        public override Mouse CreateMouse()
        {
            return new DellMouse();
        }
    }
}
