using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Creature 
    {
        private string name ="Undefined";
        private int maxHP = 500;
        private int hp = 0;
        public string Name
        {
            get => name;
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Wrong name!");
            }
        }
        public int HP
        {
            get => hp;
            set
            {
                if (value < 0 || value > maxHP)
                    throw new Exception("Wrong hp!");
                hp = value;
            }
        }
        public int MaxHP
        {
            get => maxHP;
            set
            {
                if (value < 0 || value > 500)
                    throw new Exception("Wrong Maxhp!");
                maxHP = value;
            }
        }
        public bool IsDead
        {
            get 
            {
                if (hp == 0)
                    return true;
                else
                    return false;
            }
        }
        public abstract void Wound(int damage);        
    }
   
}
