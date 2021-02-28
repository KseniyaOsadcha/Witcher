using System;

namespace Witcher
{
    class MagicalClothes : Clothes
    {
        public int gain;
        public GainType gainType;

        public MagicalClothes(int gain, GainType gainType, int id, string name, int strength, ClothesType clothesType):base( id,  name, strength, clothesType)
        {
            this.gain = gain;
            this.gainType = gainType;
        }

        public override void info()
        {
            Console.WriteLine($"id: {id}; \t name: {name}; \t strength: {strength}; \t gain: {gain}; \t gainType: {gainType}; \t clothesType: {clothesType}; ");

        }
        public override void decrease_strength(double dec)
        {
            return;
        }

    }
}
