using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("LINQ");

            //meetodid
            MaxLINQ();
            SingleOrDefault();
        }

        public static void MaxLINQ()
        {
            var players = new List<Player> {
                new Player { Name = "Alex", Team = "A", Score = 10 },
                new Player { Name = "Anna", Team = "A", Score = 20 },
                new Player { Name = "Jo", Team = "L", Score = 60 },
                new Player { Name = "Jonas", Team = "L", Score = 40 }
            };

            var teamBestScores =
                from player in players
                group player by player.Team into playerGroup
                select new
                {
                    Team = playerGroup.Key,
                    BestScore = playerGroup.Max(x => x.Score),
                };

            //teamBestScores kogub anonüümseid objekte:
            // { Team = "A", BestScore = 20 }
            // { Team = "L", BestScore = 60 }

            // Print the team best scores to the console
            foreach (var team in teamBestScores)
            {
                Console.WriteLine($"Team: {team.Team}, Best score: {team.BestScore}");
            }
        }

        public static void SingleOrDefault()
        {
            IList<int> oneElement = new List<int>() { 7 };

            Console.WriteLine("Single or Default");

            //singleOrDefault lubab ainult ühte elementi kasutada listis
            var singleOrDefault = oneElement.SingleOrDefault();

            Console.WriteLine(singleOrDefault);
        }
    }
}