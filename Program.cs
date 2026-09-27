using System;

namespace GameInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO INHERITANCE ===");

            Console.WriteLine("1. Membuat objek warrior (dengan konstruktor berparamenter)");
            Warrior warrior = new Warrior(50, "W-001", "Arthas", 100, "Stormwind");
            warrior.DisplayData();

            Console.WriteLine("2. Membuat objek Mage (dengan konstruktor berparamenter)");
            Mage mage = new Mage(80, "M-001", "Jiana", 90, "Dalaran");
            mage.DisplayData();

            Console.WriteLine("3. Membuat objek warrior (dengan konstruktor berparamenter)");
            ArchMage archMage = new ArchMage(120, 80, "AM-001", "Khadgar", 110, "Karazhan");
            archMage.DisplayData();

            

            Console.ReadKey();
        }
    }
}