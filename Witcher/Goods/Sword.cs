using System;

namespace Witcher
{
    class Sword: Weapon
    {
        public double strength; // must be 40-100

        public Sword(int strength, int id, string name, int power)
            : base(id, name, power)
        {
            this.strength = strength;
        }

        public override void info()
        {
            Console.WriteLine($"id: {id}; \t name: {name};  \t power: {power}; \t strength: {strength}; ");

        }

        public override double count_power()
        {
            double force = power*strength/100;
            this.strength -= 5;
            return force;
        }
    }
}
