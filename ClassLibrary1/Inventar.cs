using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Inventar<Item>
    {
        public Inventar()
        {

        }
        public Inventar(string owner,int size,int maxSize)
        {
            Owner = owner;
            Size = size;
            MaxSize = maxSize;
        }       
        
        private string owner = "undefined";
        private int size = 0;
        private int maxSize = 0;

        public string Owner
        {
            get => owner;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Owner is empty");
                owner = value.Trim();
            }
        }                
        public int Size
        {
            get => size;
            set
            {
                if (value <= 0 && value > maxSize)
                    throw new Exception("Wrong price!");
                size = value;
            }
        }
        public int MaxSize
        {
            get => maxSize;
            set
            {
                if (maxSize <= 0)
                    throw new Exception("Wrong maxSize!");
                maxSize = value;
            }
        }
        public void Add(Item item)
        {
            this.Add(item);
        }
        public void Remove(Item item) 
        {
            this.Remove(item);
        }
    }
}
