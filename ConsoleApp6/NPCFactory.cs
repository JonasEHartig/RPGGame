using System;

namespace ConsoleApp6
{
    internal class NPC
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Status { get; set; }
        public string HomeTown { get; set; }
        public int Speech { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Warfare { get; set; }
        public int Health { get; set; }

        public NPC(string name, int age, string status, string homeTown, int speech, int strength, int agility, int warfare, int health)
        {
            Name = name;
            Age = age;
            Status = status;
            HomeTown = homeTown;
            Speech = speech;
            Strength = strength;
            Agility = agility;
            Warfare = warfare;
            Health = health;
        }

        public void PrintEnemyStats()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(Name);
            Console.WriteLine("\nHome town: " + HomeTown);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Current status: " + Status);
            Console.WriteLine();
            Console.WriteLine("Speech: " + Speech);
            Console.WriteLine("Strength: " + Strength);
            Console.WriteLine("Agility: " + Agility);
            Console.WriteLine("Warfare: " + Warfare);
            Console.WriteLine();
            Console.WriteLine("Health: " + Health);

            Console.ReadLine();
        }
    }

    internal class NPCFactory
    {
        public NPC CreateNPC(string name, int age, string status, string homeTown, int speech, int strength, int agility, int warfare, int health)
        {
            return new NPC(name, age, status, homeTown, speech, strength, agility, warfare, health);
        }
    }

    internal class CreateNPC
    {
        public static void Main(string[] args)
        {
            NPCFactory npcFactory = new NPCFactory();


            NPC josef = npcFactory.CreateNPC("Josef", 40, "Inkeeper", "Rattay", 6, 5, 1, 3, 95);
            NPC janik = npcFactory.CreateNPC("Janik", 37, "Wanderer", "Kuttenberg", 2, 5, 3, 7, 100);
            NPC bandit = npcFactory.CreateNPC("Bandit", 25, "Nomad", "Forest", 3, 5, 4, 6, 80);
            NPC sebastian = npcFactory.CreateNPC("Guard", 35, "Guard of Sir Radzig", "City", 6, 7, 3, 5, 100);

            //bandit.PrintEnemyStats();
            //guard.PrintEnemyStats();
        }
    }
}
