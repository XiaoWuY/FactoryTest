using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest
{
    //戴尔鼠标
    public class DellMouse : Mouse
    {
        public override void Print()
        {
            Console.WriteLine("生产了一个Dell鼠标！");
        }
    }
}
