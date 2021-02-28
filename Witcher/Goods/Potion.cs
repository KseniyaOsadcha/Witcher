using System;

namespace Witcher
{
    class Potion : IGoods
    {
        public int id { get ; set ; }
        public string name { get; set; }
        public int gain;
        public GainType gainType;

        public Potion(int id, string name, int gain, GainType gainType)
        {
            this.id = id;
            this.name = name;
            this.gain = gain;
            this.gainType = gainType;
        }

        public void info()
        {
            Console.WriteLine($"id: {id}; \tgain: {gain}; \tname: {name}; \tgainType: {gainType}; ");
        }
    }
}
