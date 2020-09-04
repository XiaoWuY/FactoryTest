using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest
{
    //华硕鼠标
    public class AsusMouse : Mouse
    {
        public override void Print()
        {
            Console.WriteLine("生产了一个华硕鼠标！");
        }
    }
}
