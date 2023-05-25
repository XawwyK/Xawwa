using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Team
    {
        public Coach Coach { get; set; }
        public FbPlayer[] Players { get; set; }

        public double CalculateAverageAge()
        {
            int totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }
            return (double)totalAge / Players.Length;
        }
    }
}
