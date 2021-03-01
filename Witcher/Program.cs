using System;
using System.Collections.Generic;

namespace Witcher
{
    
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Witcher!");

            // add players
            List<Witcher> witchers = new List<Witcher>();
            create_player(ref witchers);
            Console.WriteLine("All Withers");
            witchers.ForEach(x => x.info());
            //witchers.ForEach(x => x.inventory.info());
            
            Console.WriteLine();
            Console.WriteLine();

            //foreach (Witcher witcher in witchers)
            //{
            //    Console.WriteLine("Wither's info");
            //    Console.WriteLine();
            //    witcher.info();
            //    Console.WriteLine();
            //    Console.WriteLine("Wither's inventory");
            //    Console.WriteLine();

            //    Console.WriteLine("Wither's potions");
            //    witcher.inventory.potions.ForEach(x => x.info());
            //    Console.WriteLine();
            //    Console.WriteLine("Wither's clothes");
            //    witcher.inventory.clothes.ForEach(x => x.info());
            //    Console.WriteLine();
            //    Console.WriteLine("Wither's weapons");
            //    witcher.inventory.weapons.ForEach(x => x.info());
                
                
            //    Console.WriteLine();
            //    Console.WriteLine();

            //}

            Game g = new Game();
            g.players = witchers;
            g.start_tournament();
        }

        static string[] names = { "Bill", "Poli", "James", "Agent007", "Dog" };
        static void create_player(ref List<Witcher> witchers)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Witcher w = new Witcher(names[rnd.Next(names.Length)], rnd.Next(80, 300), create_inventory());
                w.calculate_force();
                w.calculate_protect();
                witchers.Add(w);
            }

        }
        static Inventory create_inventory()
        {

            // Add potion  
            List<Potion> potions = new List<Potion>();
            AddPotions(ref potions);
            //potions.ForEach(x=>x.info());

            // Add clothes
            List<Clothes> clothes = new List<Clothes>();
            AddClothes(ref clothes);
            //clothes.ForEach(x => x.info());

            // Add Weapon
            List<Weapon> weapons = new List<Weapon>();
            AddWeapon(ref weapons);
            //weapons.ForEach(x => x.info());
            Inventory inv = new Inventory();
            inv.potions = potions;
            inv.clothes = clothes;
            inv.weapons = weapons;
            inv.equipment = new Equipment();
            return inv;
        }

        static void AddPotions(ref List<Potion> potions)
        {
            Random rnd = new Random();
            int enumLength = Enum.GetValues(typeof(GainType)).Length;

            for (int i = 0; i < 5; i++)
            {
                GainType gain = (GainType)rnd.Next(0, enumLength);
                potions.Add(new Potion(i, gain.ToString(), rnd.Next(1, 5), gain));
            }
        }
        static void AddClothes(ref List<Clothes> clothes)
        {
            Random rnd = new Random();
            int clothesEnumLength = Enum.GetValues(typeof(ClothesType)).Length;

            for (int i = 0; i < 10; i++)
            {
                ClothesType cl = (ClothesType)rnd.Next(0, clothesEnumLength);
                clothes.Add(new Clothes(i, cl.ToString(), rnd.Next(10, 90), cl));
            }

            //int gainEnumLength = Enum.GetValues(typeof(GainType)).Length;

            //for (int i = 10; i < 16; i++)
            //{
            //    ClothesType cl = (ClothesType)rnd.Next(0, clothesEnumLength);
            //    GainType gain = (GainType)rnd.Next(0, gainEnumLength);
            //    clothes.Add(new MagicalClothes(rnd.Next(1, 5), gain, i, cl.ToString(), rnd.Next(10, 90), cl));
            //}

        }
        static void AddWeapon(ref List<Weapon> weapons)
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                weapons.Add(new Bow(rnd.Next(40, 100), i, "Bow", rnd.Next(15, 50)));
            }

            for (int i = 3; i < 6; i++)
            {
                weapons.Add(new Sword(rnd.Next(40, 100), i, "Sword", rnd.Next(15, 50)));
            }
            for (int i = 6; i < 9; i++)
            {
                weapons.Add(new Magic(rnd.Next(1000, 3000), i, "Magic", rnd.Next(15, 50)));
            }

        }
    }
}
