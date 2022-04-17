using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ICombatan
    {        
        public int MinAttack { get; set; }     

        public int MaxAttack { get; set; }
        
        public int GetAttack(int bonus)
        {
            Random rnd = new Random();
            return rnd.Next(MinAttack, MaxAttack) + bonus;
        }
        public void Heal();
        
    }
}
