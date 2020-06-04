using System;
using System.Collections.Generic;
using System.Text;

namespace Course_work.Models
{
    public class Player
    {
        public string Name;
        public int Id { get; set; }
        public Player(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Player(Player player)
        {
            Name = player.Name;
            Id = player.Id;
        }
    }
}