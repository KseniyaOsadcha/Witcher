using System;

namespace Witcher
{
    class Equipment
    {
        public Clothes Helmet;
        public Clothes Footwear;
        public Clothes Armor;
        public Clothes Pants;
        public Clothes Gloves;


        public virtual void info()
        {
            if (Helmet != null)
            {
                Console.WriteLine("Helmet: ");
                Helmet.info();
            }
            if (Footwear != null)
            {
                Console.WriteLine("Footwear: ");
                Footwear.info();
            }
            if (Armor != null)
            {
                Console.WriteLine("Armor: ");
                Armor.info();
            }
            if (Pants != null)
            {
                Console.WriteLine("Pants: ");
                Pants.info();
            }
            if (Gloves != null)
            {
                Console.WriteLine("Gloves: ");
                Gloves.info();
            }
        }
        public double calculate_strength()
        {
            double sum = 0;
            double count = 0;
            if (Helmet != null)
            {
                sum += Helmet.strength;
                count++;
            }
            if (Footwear != null)
            {
                sum += Footwear.strength;
                count++;
            }
            if (Armor != null)
            {
                sum += Armor.strength;
                count++;
            }
            if (Pants != null)
            {
                sum += Pants.strength;
                count++;
            }
            if (Gloves != null)
            {
                sum += Gloves.strength;
                count++;
            }
            if (count == 0) return 1;
            else return sum / count;
        }
    }
}
