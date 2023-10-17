namespace HumanTwo;
class Program
{
    static void Main(string[] args)
    {
        Wizard wiz = new("siker", 12, 13);
        Human human = new("512kb");
        Ninja ninja = new("Zote", 12, 13, 100);
        Samurai samurai = new("Monizote", 25, 20, 40);
        // wiz.Attack(human);
        // wiz.Heal(human);
        // ninja.Attack(human);
        // ninja.Steal(wiz);
        samurai.Attack(ninja);
        samurai.Attack(ninja);
    }
}
