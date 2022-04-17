using System;
using ClassLibrary1;

namespace TMS.Ex9
{
    class Program
    {
        static void Main(string[] args)
        {           
            Humanoid orc = new Humanoid(Humanoid.HumanoidType.Orc,300, new Inventar<Item>());
            orc.Inventar.Add(new Item("Боевой меч", Item.itemType.Sword, 250, 50));
            orc.Inventar.Add(new Item("Прочный щит", Item.itemType.Shield, 150, 150));
           
            Hero Frodo = new Hero(Humanoid.HumanoidType.Orc, 300, new Inventar<Item>());
            Console.WriteLine(Frodo.IQ);
        }
    }
}
