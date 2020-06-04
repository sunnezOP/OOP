using System;
using System.Collections.Generic;
using System.Text;

namespace Course_work.Models
{

    public class History
    {
        public List<Match> Future_Matches = new List<Match>();
        public delegate void Messege(string message);
        public static event Messege Notify;
        public void AddtoHistory(Match match)
        {
            Future_Matches.Add(match);
            Notify?.Invoke($"New match #{Future_Matches.Count} added to history!!!");
        }
    }
}
