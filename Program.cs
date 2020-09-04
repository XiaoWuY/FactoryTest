using System;

namespace FactoryTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===========不用工厂的方式==========");
            Mouse mouse1 = new DellMouse();
            Mouse mouse2 = new HpMouse();
            mouse1.Print();
            mouse2.Print();
            Console.WriteLine("============================");
            Console.WriteLine("===========简单工厂==========");
            //实例化一个工厂类
            SimpleFactory.MouseFactory mouseFactory = new SimpleFactory.MouseFactory();
            //通过工厂类创建鼠标
            Mouse simpleMouse1 = mouseFactory.CreateMouse("dell");
            Mouse simpleMouse2 = mouseFactory.CreateMouse("hp");
            simpleMouse1.Print();
            simpleMouse2.Print();
            Console.WriteLine("============================");
            Console.WriteLine("===========工厂方法==========");
            //生产一个戴尔鼠标
            FactoryMethod.MouseFactory dellMouseFactory = new FactoryMethod.DellMouseFactroy();
            Mouse dellMouse = dellMouseFactory.CreateMouse();
            dellMouse.Print();

            //生产一个惠普鼠标
            FactoryMethod.MouseFactory hpMouseFactory = new FactoryMethod.HpMouseFactory();
            Mouse hpMouse = hpMouseFactory.CreateMouse();
            hpMouse.Print();

            //生产一个华硕鼠标
            FactoryMethod.MouseFactory asusMouseFactory = new FactoryMethod.AsusMouseFactroy();
            Mouse asusMouse = asusMouseFactory.CreateMouse();
            asusMouse.Print();
            Console.WriteLine("============================");
            Console.WriteLine("===========抽象工厂==========");
            //生产一个戴尔鼠标/键盘
            AbstractFactory.PcFactory dellFactory = new AbstractFactory.DellPcFactroy();
            Mouse dellMouse3 = dellFactory.CreateMouse();
            Keyboard dellKeyboard = dellFactory.CreateKeyboard();
            dellMouse3.Print();
            dellKeyboard.Print();

            //生产一个惠普鼠标/键盘
            AbstractFactory.PcFactory hpFactory = new AbstractFactory.HpPcFactory();
            Mouse hpMouse3 = hpFactory.CreateMouse();
            Keyboard hpKeyboard = hpFactory.CreateKeyboard();
            hpMouse3.Print();
            hpKeyboard.Print();


            Console.ReadKey();
        }
    }
}
