using System;
using System.Collections.Generic;

namespace Witcher
{
    class Inventory
    {
        public List<Potion> potions = new List<Potion>();
        public List<Potion> activePotions = new List<Potion>();

        public List<Clothes> clothes = new List<Clothes>();
        public Equipment equipment;

        public List<Weapon> weapons = new List<Weapon>();
        public Weapon activeWeapon;


        // equiperate


        public void equipWeapon(Weapon weapon)
        {
            activeWeapon = weapon;
            Console.WriteLine("Active Weapon:");
            activeWeapon.info();
        }


        public void addPotion(Potion potion)
        {
            potions.Add(potion);
            Console.WriteLine("Success");
            activePotions.ForEach(x => x.info());
        }


        public void equipClothes(Clothes clothes)
        {
            if (clothes.clothesType == ClothesType.Armor)
            {
                equipment.Armor = clothes;
                Console.WriteLine("Success");
                equipment.Armor.info();
            }
            else if (clothes.clothesType == ClothesType.Pants)
            {
                equipment.Pants = clothes;
                Console.WriteLine("Success");
                equipment.Pants.info();
            }
            else if (clothes.clothesType == ClothesType.Helmet)
            {
                equipment.Helmet = clothes;
                Console.WriteLine("Success");
                equipment.Helmet.info();
            }
            else if (clothes.clothesType == ClothesType.Gloves)
            {
                equipment.Gloves = clothes;
                Console.WriteLine("Success");
                equipment.Gloves.info();
            }
            else if (clothes.clothesType == ClothesType.Footwear)
            {
                equipment.Footwear = clothes;
                Console.WriteLine("Success");
                equipment.Footwear.info();
            }
        }


        // write information about inventory

        public void info()
        {
            Console.WriteLine("equipment:");
            equipment.info();

            Console.WriteLine("Active Weapon:");
            if (activeWeapon != null)
            {
                activeWeapon.info();
            }
            Console.WriteLine("Active Potions:");
            activePotions.ForEach(x => x.info());

        }

        public void WriteWeaponList()
        {
            weapons.ForEach(x => x.info());
        }
        public void WriteClothesList()
        {
            clothes.ForEach(x => x.info());
        }
        public void WritePotionList()
        {
            potions.ForEach(x => x.info());
        }
    }
}
