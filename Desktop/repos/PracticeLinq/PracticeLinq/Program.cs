using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carNames = { "Acura", "Alfa Romeo", "Aston Martin", "Bently", "Bugatti", "Jaguar", "Land Rover", "TaTa", "Tesla", "Gmc","Kia" };

           var carsWithA = from car in carNames where car.Contains("a") orderby car descending select car; 

            foreach(var item in carsWithA)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------------------");

            var videoGames = new List <string>();
            videoGames.Add("Doom");
            videoGames.Add("Zelda");
            videoGames.Add("Tetris");
            videoGames.Add("Pac-Man");
            videoGames.Add("Minecraft");
            videoGames.Add("Elder Scrolls");
            videoGames.Add("Space Invaders");


            foreach(var s in videoGames)
            {
                for(int x = 0; x < 1; x++)
                {
                    Console.WriteLine(s);
                }
                
            }

            Console.WriteLine("************************************************************");

            IEnumerable<string> name = videoGames.Where(n => n.Contains("a"));
             
              foreach(var item in name)
              {
                Console.WriteLine(item);
              }
                
            
          

           
            
        }
    }
}
