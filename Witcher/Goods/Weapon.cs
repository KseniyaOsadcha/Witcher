using System;

namespace Witcher
{
    abstract class Weapon : IGoods
    {
        public int id { get; set; }
        public string name { get; set; }
        public double power; // must be 15 - 100 (or more)

        protected Weapon(int id, string name, int power)
        {
            this.id = id;
            this.name = name;
            this.power = power;
        }

        public virtual void info()
        {
            Console.WriteLine("hi from abstract class Weapon");
        }
        public virtual double count_power() {
            return power;
        }

    }
}
