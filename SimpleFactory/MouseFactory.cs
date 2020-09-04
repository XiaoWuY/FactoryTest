using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest.SimpleFactory
{
    /// <summary>
    /// 鼠标工厂类
    /// </summary>
    public class MouseFactory
    {
        private Mouse mouse = null;
        public Mouse CreateMouse(string brand)
        {
            switch (brand)
            {
                case "dell":
                    mouse = new DellMouse();
                    break;
                case "hp":
                    mouse = new HpMouse();
                    break;
                default:
                    break;
            }
            return mouse;
        }
    }
}
