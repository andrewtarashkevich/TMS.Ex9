using System;

namespace ClassLibrary1
{
    public class Item
    {
        public Item(string name, itemType type, int price, int weight)
        {
            Name = name;
            Type = type;
            Price = price;
            weight = weight;
        }
        private string name = "undefined";
        private int price = 0;
        private int weight = 0;
        public string Name 
        {
            get => name;
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name is empty");
                name = value.Trim();
            }
        }
        public enum itemType
        {
            Sword,
            Knife,
            Axe,
            Spear,
            Gun,
            Shield
        }
        public itemType Type { get; set; }
        public int Price 
        {
            get => price;
            set 
            {
                if (value <= 0)
                    throw new Exception("Wrong price!");
                price = value;
            }
        }
        public int Weight
        {
            get => weight;
            set 
            {
                if (weight <= 0)
                    throw new Exception("Wrong weight!");
                weight = value;
            }
        }
        
    }
}
