namespace GameInheritanceDemo
{
    public class Warrior : Character
    {
        public int bonus;

        public Warrior() : base()
        {
            Console.WriteLine("----> Konstruktor deaflut Warrior <----");
            Console.WriteLine("4. Membuat objek Warrior dengan konstruktor default");
            Warrior defaultWarrior = new Warrior();
            defaultWarrior.DisplayData();
        }


        

        public Warrior(int bonus, string id, string name, int basePower, string address)
        : base(id, name, basePower, address)
        {
            Console.WriteLine("----> Konstruktor berparamenter Warrior <----");
            this.bonus = bonus;
        }

        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("BONUS            =" + bonus);
            Console.WriteLine("TOTAL POWER      =" + (GetBasePower() + bonus));
            Console.WriteLine("====================");
        }
    }
}