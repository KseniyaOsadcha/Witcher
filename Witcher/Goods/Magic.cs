using System;

namespace Witcher
{
    class Magic: Weapon
    {
        public int recharge; // must be 1000-3000
        public DateTime last_time;
       

        public Magic(int recharge, int id, string name, int power)
            : base(id, name, power)
        {
            this.recharge = recharge;
            this.last_time = DateTime.Now;
        }

        public override void info()
        {
            Console.WriteLine($"id: {id}; \t name: {name};  \t power: {power}; \t recharge: {recharge}; ");
        }

        public override double count_power()
        {
            DateTime now = DateTime.Now;
            if (now.Ticks - last_time.Ticks > recharge)
            {
                last_time = now;
                return power * 1.5;
            }
            else
                return power;
        }

    }
}
