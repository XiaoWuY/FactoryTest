using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest
{
    //戴尔键盘类
    public class DellKeyboard : Keyboard
    {
        public override void Print()
        {
            Console.WriteLine("生产了一个Dell键盘！");
        }
    }
}
