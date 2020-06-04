using System;
using System.Collections.Generic;
using Course_work.Models;

namespace Course_work.Models
{
    public class Team
    {
        public string Name;
        public List<Pair<Player, int>> Players = new List<Pair<Player, int>>();
        public Team(List<Pair<Player, int>> players, string name)
        {
            Players = players;
            Name = name;
        }
        public Team(string name)
        {
            Name = name;
        }

        public void AddPlayer(Player player, int number)
        {
            bool available = false;
            if (Players != null)
            {
                foreach (var item in Players)
                {
                    if ((player.Id == item.First.Id) ^ (player.Name == item.First.Name))
                    {
                        Console.WriteLine("Player is already in the team or this team already has player with this ID");
                        available = true;
                        break;
                    }
                }
            }
            if (!available)
            {
                var pair = new Pair<Player, int>();
                pair.First = new Player(player);
                pair.Second = number;
                Players.Add(pair);
            }


        }
    }
}
