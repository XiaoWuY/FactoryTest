using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest
{
    //惠普鼠标
    public class HpMouse : Mouse
    {
        public override void Print()
        {
            Console.WriteLine("生产了一个惠普鼠标！");
        }
    }
}
