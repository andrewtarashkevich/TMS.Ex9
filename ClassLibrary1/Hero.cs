using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Hero : Humanoid, ICombatan
    {
        public Hero()
        {

        }
        public Hero(HumanoidType type, int iq, Inventar<Item> inv)
        {
            Type = type;
            IQ = iq;
            Inventar = inv;
        }
        private int minAttack;
        public int MinAttack
        {
            get => minAttack;
            set
            {
                if (value > 0 && value < 10)
                    minAttack = value;
                else
                    throw new Exception("Invalid MinAttack");
            }
        }

        private int maxAttack;
        public int MaxAttack
        {
            get => maxAttack;
            set
            {
                if (value >= 20 && value <= 100)
                    maxAttack = value;
                else
                    throw new Exception("Invalid MaxAttack");
            }
        }
        public void Heal()
        {
            HP = MaxHP;
        }
    }
}
