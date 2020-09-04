using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest.FactoryMethod
{
    /// <summary>
    /// 鼠标工厂抽象类
    /// </summary>
    public abstract class MouseFactory
    {
        public abstract Mouse CreateMouse();
    }
}
