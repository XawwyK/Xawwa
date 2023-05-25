using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Person[] AssistantReferees { get; set; }
        public Goal[] Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public void PrintResult()
        {
            Console.WriteLine("Game Result:");
            Console.WriteLine("Team 1: " + Team1.Coach.Name);
            Console.WriteLine("Team 2: " + Team2.Coach.Name);
            Console.WriteLine("Result: " + Result);
            Console.WriteLine("Winner: " + Winner.Coach.Name);
        }
    }
}
