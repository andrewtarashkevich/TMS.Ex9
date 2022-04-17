using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum MonsterType
    {
        dragon,
        orc,
        undead,
        demon
    }
    public class Monster : Creature, ICombatan
    {
        public Monster()
        {

        }
        public Monster(string name, MonsterType mo, int hp, int maxHP, int minAttack, int maxAttack, string warCry, string dieCry)
        {
            Name = name;
            MonsterType = mo;
            HP = hp;
            MaxHP = maxHP;
            MinAttack = minAttack;
            MaxAttack = maxAttack;
            WarCry = warCry;
            DieCry = dieCry;
        }
        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (value != "")
                    name = value;
                else
                    throw new Exception("Invalid name!");
            }
        }
        
        public MonsterType MonsterType { get; set; }

        private int hp;
        public int HP
        {
            get
            {
                return hp;
            }
            set
            {
                if (value >= 0 && value <= 500 && value <= maxHP)
                    hp = value;
                else
                    throw new Exception("Invalid HP");
            }
        }

        private int maxHP = 500;
        public int MaxHP
        {
            get
            {
                return maxHP;
            }
            set
            {
                if (value > 0 && value <= 500)
                    maxHP = value;
                else
                    throw new Exception("Invalid MaxHP");
            }
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

        public string WarCry { get; set; }
        public string DieCry { get; set; }

        public string TypeText
        {
            get
            {
                switch (MonsterType)
                {
                    case MonsterType.dragon:
                        return "Дракон";
                        break;
                    case MonsterType.demon:
                        return "Демон";
                        break;
                    case MonsterType.orc:
                        return "Орк";
                        break;
                    case MonsterType.undead:
                        return "мертвец";
                        break;
                    default:
                        return "Нету типа";
                        break;
                }
            }
        }
        public bool IsAlive
        {
            get
            {
                if (HP > 0)
                    return true;
                else
                    return false;
            }
        }
        public string[] GetInfo
        {
            get
            {
                string title = "Характеристики монстра";
                string name = "Имя: " + Name;
                string hp = "Здоровье: " + HP;
                string maxat = "Максимальная атака: " + MaxAttack;
                string minat = "Минимальная атака: " + MinAttack;
                string warcry = "Боевой клич: " + WarCry;
                string diecry = "Предсметрный плач: " + DieCry;
                return new string[] { title, name, hp, maxat, minat, warcry, diecry };
            }

        }

        public int GetAttack(int bonus)
        {
            Random rnd = new Random();
            return rnd.Next(MinAttack, MaxAttack) + bonus;
        }
        public void Heal()
        {
            HP = MaxHP;
        }

        public override void Wound(int damage)
        {
            if (HP - damage >= 0)
                HP = HP - damage;
            else
                HP = 0;
        }
    }
}
