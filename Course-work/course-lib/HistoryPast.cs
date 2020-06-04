using System;
using System.Collections.Generic;
using System.Text;

namespace Course_work.Models
{

    public class HistoryPast
    {
        public List<Match> Past_Matches = new List<Match>();
        public delegate void Messege(string message);
        public static event Messege Notify;
        public void AddtoHistory(Match match)
        {
            Past_Matches.Add(match);
            Notify?.Invoke($"New match #{Past_Matches.Count} added to history!!!");
        }
    }
}
