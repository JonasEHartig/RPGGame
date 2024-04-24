using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Media;
using ConsoleApp6;
namespace Program
{
    internal class NewStory
    {
        public NewStory()
        {
            
        }
        public Character player = new Character("Henry", 19, "Blacksmith apprentice", "Skalitz", 2, 3, 3, 1, 100, 43);
        

        public void Start()
        {

            Console.WriteLine("Start?");
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(4000);

            Console.WriteLine("Skalitz");
            Thread.Sleep(1500);
            Console.WriteLine("1403");
            Thread.Sleep(2000);
            Console.Clear();
            Thread.Sleep(3000);


            Console.WriteLine("Someone enters the door,");
            Thread.Sleep(2500);
            Console.WriteLine("and with it enters light.");
            Thread.Sleep(2500);
            Console.Clear();
            Thread.Sleep(1500);
            Console.Write("It is mother"); Thread.Sleep(500); Console.Write("."); Thread.Sleep(500); Console.Write("."); Thread.Sleep(500); Console.Write(".");
            Thread.Sleep(1000);
            Console.WriteLine("\n-------------");
            Console.WriteLine("|Continue...|");
            Console.WriteLine("-------------");
            Console.ReadLine();
            Thread.Sleep(500);
            Console.Clear();
            Thread.Sleep(3000);
            Console.WriteLine("\"Henry, it's pass sunrise.\"");
            Thread.Sleep(3000);
            Console.WriteLine("\n\"Pa's got a lot of work on his hands.\"");
            Thread.Sleep(3000);
            Console.WriteLine("\n\"He would like you to run some errands for him.\"");
            Thread.Sleep(5000);
            Console.Clear();
            Thread.Sleep(2000);
            Console.WriteLine("\"Henry, what's happend to you hand?\"");
            Thread.Sleep(3000);
            Console.WriteLine("\n\"Have you been sword fighting again? We have already discussed this?\"");
            Thread.Sleep(1500);
            Valg();
        }
            public void Valg()
            {
                    Console.WriteLine("\n--------------------------------------------------------------------------");
                    Console.WriteLine("Pick your anwser \n1: I scratched my hand while i was dancing with Bianca in the tavern (Agility) \n2: I was having an ale in the tavern with Mathew and Fritz (Speech) \n3: I was getting logs for pa (Strength) \n4: I didnt get hurt ma, I'm fine (Warfare)");
                    Console.Write("\n:");
                    string PlayerChoice = Console.ReadLine();
                
           

                if (PlayerChoice == "1")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Thread.Sleep(250);

                    Console.Write("/You Agility has increased by 1: " + player.Agility + "--->");
                    player.ChangeAgility(1);
                    Console.Write(player.Agility + "\\");
                    Thread.Sleep(4000);

                    Console.WriteLine("\n\nI was in the tavern, dancing with Bianca when i stumpled and scratched my hand.");
                    Thread.Sleep(4000);
                    Console.WriteLine("\n\nIt happens ma', come off it.");

                    Thread.Sleep(5000);
                    Console.WriteLine("\n-------------");
                    Console.WriteLine("|Continue...|");
                    Console.WriteLine("-------------");
                    Console.ReadLine();
                    Thread.Sleep(500);
                    Console.Clear();
                }
                else if (PlayerChoice == "2")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Thread.Sleep(250);

                    Console.Write("/Your Speech has increased by 1: " + player.Speech + "--->");
                    player.ChangeSpeech(1);
                    Console.Write(player.Speech + "\\");
                    Thread.Sleep(4000);

                    Console.WriteLine("\n\nI was talking to Mathew and Fritz in the tavern over an ale ma', when Fritz spilled boiling water over my hand.");
                    Thread.Sleep(4000);
                    Console.WriteLine("\nIt was nothing serious.");


                    Thread.Sleep(5000);
                    Console.WriteLine("\n-------------");
                    Console.WriteLine("|Continue...|");
                    Console.WriteLine("-------------");
                    Console.ReadLine();
                    Thread.Sleep(500);
                    Console.Clear();
        
                }
                else if (PlayerChoice == "3")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Thread.Sleep(250);

                    Console.Write("/You Strength has increased by 1: " + player.Strength + "--->" );
                    player.ChangeStrength(1);
                    Console.Write(player.Strength + "\\");
                    Thread.Sleep(4000);

                    Console.WriteLine("\n\nPa needed logs for his smith and asked me to get some for him, but had an accident.");
                    Thread.Sleep(4000);
                    Console.WriteLine("\nIts not too bad ma', come of it.");


                    Thread.Sleep(5000);
                    Console.WriteLine("\n-------------");
                    Console.WriteLine("|Continue...|");
                    Console.WriteLine("-------------");
                    Console.ReadLine();
                    Thread.Sleep(500);
                    Console.Clear();


                }
                else if (PlayerChoice == "4")
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.Write("/You Warfare has increased by 1: " + player.Warfare + "--->");
                    player.ChangeWarfare(1);
                    Console.Write(player.Warfare + "\\");
                    Thread.Sleep(4000);

                    Console.WriteLine("\n\nIt was just a short spar with Janik");
                    Thread.Sleep(4000);
                    Console.WriteLine("\nIt was nothing serious ma', come of it");

                    Thread.Sleep(5000);
                    Console.WriteLine("\n-------------");
                    Console.WriteLine("|Continue...|");
                    Console.WriteLine("-------------");
                    Console.ReadLine();
                    Thread.Sleep(500);
                    Console.Clear();
                }
                else
                {

                    Console.WriteLine("\n*You have typed a non coresponding character, please pick a valid anwser*");
                    Thread.Sleep(3500);
                    Console.Clear();

                    Valg();
                }
                Thread.Sleep(4000);
                player.PrintStats();


            }
        public void SparJanik()
        {



        }
        
    }
}
