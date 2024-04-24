using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Character
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
        public string Status {  get; set; }
        public int Speech {  get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Warfare { get; set; }
        public int Health { get; set; }
        public int Hunger { get; set; }
        
        public Character(string name, int age, string status, string hometown, int speech, int strenght, int agility, int warfare, int health, int hunger) 
        {
            Name = name;
            Age = age;
            Status = status;
            HomeTown = hometown;
            Speech = speech;
            Strength = strenght;
            Agility = agility;
            Warfare = warfare;
            Health = health;
            Hunger = hunger;
            
        }
        public void ChangeStatus(string NewStatus)
        {
            Status = NewStatus;
        }
        public void ChangeSpeech(int NewSpeech)
        {
            Speech += NewSpeech;
        }
        public void ChangeStrength(int NewStrength)
        {
            Strength += NewStrength;
        }
        public void ChangeAgility(int NewAgility)
        {
             Agility += NewAgility;
        }
        public void ChangeWarfare(int NewWarfare)
        {
            Warfare += NewWarfare;
        }
        public void ChangeHealth(int NewHealth)
        {
            Health += NewHealth;
        }
        public void ChangeHunger(int NewHunger)
        {
            Hunger += NewHunger;
        }

        public void PrintStats()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(Name);
            Console.WriteLine("Home town: " + HomeTown);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Current status: " + Status);
            Console.WriteLine();
            Console.WriteLine("Speech: " + Speech);
            Console.WriteLine("Strength: " + Strength);
            Console.WriteLine("Agility: " + Agility);
            Console.WriteLine("Warfare: " + Warfare);
            Console.WriteLine();
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Hunger: " + Hunger);

            Console.ReadLine();
        }

    }
}
