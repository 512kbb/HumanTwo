using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanTwo
{
    public class Wizard : Human
    {
        public Wizard(string name, int str, int dex) : base(name, str, 25, dex, 50)
        {

        }

        public override int Attack(Human target)
        {
            int damage = Intelligence * 3;
            target.Health -= damage;
            this.Health += damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!, {this.Name} current health {this.Health}, {target.Name} current health : {target.Health}");
            return target.Health;
        }

        public int Heal(Human target) 
        {
            int healQty = this.Intelligence * 3;
            target.Health += healQty;
            Console.WriteLine($"{this.Name}  healed {target.Name} for {healQty}, current health {target.Health}");
            return target.Health;
        }

    }
}