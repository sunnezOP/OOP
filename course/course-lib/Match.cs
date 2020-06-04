using System;
using System.Collections.Generic;
using System.Text;

namespace Course_work.Models
{
    public class Match
    {
        public Team Team1, Team2;
        public string Time, Name, Type;
        public int Score1, Score2;
        public Match(Team team1, Team team2, string time, string name, string type)
        {
            Team1 = team1;
            Team2 = team2;
            Time = time;
            Name = name;
            Type = type;
        }
        public Match(Team team1, Team team2, string time, string name, string type, int score1, int score2)
        {
            Team1 = team1;
            Team2 = team2;
            Time = time;
            Name = name;
            Score1 = score1;
            Score2 = score2;
            Type = type;
        }
    }
}
