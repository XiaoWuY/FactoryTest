using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryTest
{
    //惠普键盘
    public class HpKeyboard : Keyboard
    {
        public override void Print()
        {
            Console.WriteLine("生产了一个惠普键盘！");
        }
    }
}
