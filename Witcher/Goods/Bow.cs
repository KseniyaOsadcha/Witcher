using System;

namespace Witcher
{
    class Bow: Weapon
    {
        public int hitProbability; //must be 40 - 100
        Random rnd = new Random();

        public Bow(int hitProbability, int id, string name, int power)
            : base(id, name, power)
        {
            this.hitProbability = hitProbability;
        }


        public override void info()
        {
            Console.WriteLine($"id: {id}; \t name: {name}; \t power: {power}; \t hitProbability: {hitProbability}; ");

        }
        public override double count_power()
        {
            double luck = rnd.Next(1, 101);
            if (luck > 100 - hitProbability)
            {
                if (luck > 85)
                    return power*1.5;
                else
                    return power;
            }
            else
                return hitProbability/10;


        }
    }
}
