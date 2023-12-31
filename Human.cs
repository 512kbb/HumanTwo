using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanTwo
{
    public class Human
    {
        public string? Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }

        // 
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Health = hp;
        }

        public virtual int Attack(Human target)
        {
            int damage = Strength * 3;
            target.Health -= damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            return target.Health;
        }
    }
}