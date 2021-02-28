using System;

namespace Witcher
{
    class Clothes : IGoods
    {

        public int id { get; set ; }
        public string name { get; set ; }
        public double strength; // must be 10 - 90
        public ClothesType clothesType;

        public Clothes(int id, string name, double strength, ClothesType clothesType)
        {
            this.id = id;
            this.name = name;
            this.strength = strength;
            this.clothesType = clothesType;
        }

        public virtual void info()
        {
            Console.WriteLine($"id: {id}; \t name: {name}; \t strength: {strength}; \t clothesType: {clothesType}; ");

        }

        public virtual void decrease_strength(double dec)
        {
            strength -= dec;
        }
    }
}
