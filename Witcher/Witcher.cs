using System;

namespace Witcher
{
    class Witcher
    {
        public string name;
        public int win_count =0 ;
        public double force; 
        public double protect; // must be less than 90
        public double life;
        public double currentLife;
        public Inventory inventory;

        public Witcher(string name, double life, Inventory inventory)
        {
            this.name = name;
            this.life = life;
            this.currentLife = life;
            this.inventory = inventory;
        }

        public void calculate_force()
        {
            Weapon activeWeapon = inventory.activeWeapon;
            if (activeWeapon != null)
                force = activeWeapon.count_power();
            else
                force = 10;
        }
        public void calculate_protect()
        {
            protect = inventory.equipment.calculate_strength();
        }

        public void info()
        {
            Console.WriteLine($"name: {name}; \t life: {life};  \t force: {force}; \t protect: {protect};  \t win_count: {win_count};");

        }
    }
}
