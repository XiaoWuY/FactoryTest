using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest.AbstractFactory
{
    /// <summary>
    /// Pc产品工厂抽象类
    /// </summary>
    public abstract class PcFactory
    {
        public abstract Mouse CreateMouse();
        public abstract Keyboard CreateKeyboard();
    }
}
