using System;
using System.Collections.Generic;
using System.Text;

namespace Course_work.Models
{
    public class Started_info
    {
        static List<Team> begin = new List<Team>    ();
        static List<Match> Future_Matches_begin = new List<Match>();
        static List<Match> Past_Matches_begin = new List<Match>();

        public List<Team> Start_teams()
        {
            begin.Add(new Team("Spartak"));
            begin[0].AddPlayer(new Player(1, "David Barri"), 1);
            begin[0].AddPlayer(new Player(2, "Rayan Gitz"), 11);
            begin[0].AddPlayer(new Player(3, "Frank Lampard"), 10);
            begin[0].AddPlayer(new Player(4, "David Dzheyms"), 9);
            begin.Add(new Team("CSKA"));
            begin[1].AddPlayer(new Player(1, "David Barrl"), 1);
            begin[1].AddPlayer(new Player(2, "Gary Sped"), 11);
            begin[1].AddPlayer(new Player(3, "Frank Heski"), 5);
            begin[1].AddPlayer(new Player(4, "Mark Shvartzer"), 9);
            begin.Add(new Team("Manchester"));
            begin[2].AddPlayer(new Player(1, "Dzheymi Karager"), 1);
            begin[2].AddPlayer(new Player(2, "Phill Nevill"), 11);
            begin[2].AddPlayer(new Player(3, "Stiven Dzherad"), 3);
            begin[2].AddPlayer(new Player(4, "Paul Skoulz"), 9);
            begin.Add(new Team("Arsenal"));
            begin[3].AddPlayer(new Player(1, "John Tarry"), 1);
            begin[3].AddPlayer(new Player(2, "Mickle Carryk"), 11);
            begin[3].AddPlayer(new Player(3, "Silven Disten"), 10);
            begin[3].AddPlayer(new Player(4, "Piter Krauz"), 9);
            return begin;
        }
        public List<Match> Start_schedule()
        {
            Future_Matches_begin.Add(new Match(begin[0], begin[3], "30/03/2021", "Cubock", "bo1"));
            Future_Matches_begin.Add(new Match(begin[1], begin[2], "15/03/2022", "Cubock", "bo1"));
            Future_Matches_begin.Add(new Match(begin[0], begin[3], "30/03/2023", "Seria", "bo1"));
            Future_Matches_begin.Add(new Match(begin[1], begin[3], "29/05/2021", "Seria", "bo1"));
            return Future_Matches_begin;
        }
        public List<Match> Start_historry()
        {
            Past_Matches_begin.Add(new Match(begin[0], begin[3], "30/03/2021", "Cubock", "bo1", 1, 2));
            Past_Matches_begin.Add(new Match(begin[1], begin[2], "15/03/2022", "Cubock", "bo1", 3, 2));
            Past_Matches_begin.Add(new Match(begin[0], begin[3], "30/03/2022", "Seria", "bo1", 1, 0));
            Past_Matches_begin.Add(new Match(begin[1], begin[3], "29/05/2023", "Seria", "bo1", 1, 2));
            return Past_Matches_begin;
        }
    }
}
