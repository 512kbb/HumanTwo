using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanTwo
{
    public class Samurai : Human
    {
        public int baseHP = 200;
        public Samurai(string name, int str, int intel, int dex) : base(name, str, intel, dex, 200)
        {

        }

        public override int Attack(Human target)
        {
            if (target.Health < 50)
            {
                Console.WriteLine($"{this.Name} attacked {target.Name} for {target.Health}, {target.Name} fainted");
                target.Health = 0;
                return target.Health;
            }
            return base.Attack(target);
        }

        public void Meditate()
        {
            this.Health = baseHP;
        }
    }
}