using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanTwo
{
    public class Ninja : Human
    {
        public int baseDex = 75;
        public Ninja(string name, int str, int intel, int hp) : base(name, str, intel, 75, hp) 
        {

        }

        public override int Attack(Human target)
        {
            Random rand = new();
            int probability = rand.Next(10);
            int damage = this.Dexterity;
            Console.WriteLine(probability);
            if (probability == 9 || probability == 0) {
                damage += 10;
                Console.WriteLine("CRITIC!");
            }
            target.Health -= damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            return target.Health;
        }

        public int Steal(Human target) 
        {   
            target.Health -= 5;
            this.Health += 5;
            Console.WriteLine($"{this.Name} stealed 5hp from {target.Name}");
            return target.Health;
        }
    }
}