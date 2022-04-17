using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Humanoid : Creature
    {
        //Можно придумать правила по ранениям для разных рас ))
        //Например, эльфы хрупкие, и все раны для них усиливаются x1.1;
        //орки живучие и если рана должна его убить, то один раз она его не убивает, а оставляет 1 ХП (второй раз убивает);
        //дварфы крепкие и уменьшают ранения на 0.9;
        //люди без изменения и т.д.
        public Humanoid()
        {

        }
        public Humanoid(HumanoidType type, int iq, Inventar<Item> inv)
        {
            Type = type;
            IQ = iq;
            Inventar = inv;
        }      
        private int iq = 0;
        public enum HumanoidType
        {
            Human,
            Hobbit,
            Orc,
            Elve
        }
        public int IQ 
        {
            get => iq;
            set 
            {
                if (value < 0)
                    throw new Exception("Wrong iq!");
            }
        }
        public HumanoidType Type { get; set;}
        public Inventar<Item> Inventar { get; set; }
        public override void Wound(int damage)
        {
            if (HP - damage >= 0)
                HP = HP - damage;
            else
                HP = 0;
        }
    }    
}
