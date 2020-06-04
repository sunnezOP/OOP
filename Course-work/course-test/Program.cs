using System;
using System.Collections.Generic;
using System.Text;
using Course_work.Models;

namespace Course_work.Models
{
    public class Program
    {
        static List<Team> teams = new List<Team>();
        static void Main(string[] args)
        {
            Started_info start = new Started_info();
            History future_history = new History();
            HistoryPast past_history = new HistoryPast();
            History.Notify += DisplayMessage;
            teams = start.Start_teams();
            future_history.Future_Matches = start.Start_schedule();
            past_history.Past_Matches = start.Start_historry();
            Console.WriteLine("Course work var.11 Nezhevets Aleksander");
            Console.WriteLine("All rules how to use the program you can find down");
            bool flag_choose = true;
            while (flag_choose)
            {
                Console.WriteLine("Choose who are you");
                Console.WriteLine("If you are a administrator - write 1");
                Console.WriteLine("If you are a user - write 2");
                Console.WriteLine("To close the program write anything else");
                var str_choose = Console.ReadLine();
                switch (str_choose)
                {
                    case "1":
                        {
                            bool flag_1 = true;
                            while (flag_1)
                            {
                                Console.WriteLine("******************************\n");
                                Console.WriteLine("To add a player in any team, write 1");
                                Console.WriteLine("To create a team write 2");
                                Console.WriteLine("To add a match, write 3");
                                Console.WriteLine("To get back to the choose write anything");
                                var str = Console.ReadLine();
                                switch (str)
                                {
                                    case "1":
                                        {
                                            try
                                            {
                                                Console.WriteLine("Select the team, to add player, just write number");
                                                for (int i = 0; i < teams.Count; i++)
                                                {
                                                    Console.WriteLine($"{i + 1}. {teams[i].Name}");
                                                }
                                                int number_team = int.Parse(Console.ReadLine());

                                                Console.WriteLine("Write name of player: ");
                                                string name = Console.ReadLine();
                                                Console.WriteLine("Write player id, but from the start in the team 4 players(1 - 4 id): ");
                                                int id = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Write his number in the team: ");
                                                int number = int.Parse(Console.ReadLine());
                                                teams[number_team - 1].AddPlayer(new Player(id, name), number);
                                                Console.WriteLine("*****************************\n");
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine("Please write correctly!!!");
                                            }
                                            break;
                                        }
                                    case "2":
                                        {
                                            try
                                            {
                                                CreateTeam();
                                                Console.WriteLine($"You succesfully created a team");
                                                Console.WriteLine("*****************************\n");
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine("Please write correctly");
                                            }
                                            break;
                                        }
                                    case "3":
                                        {
                                            try
                                            {
                                                Console.WriteLine("Select the two teams, to add history(future) ");
                                                for (int i = 0; i < teams.Count; i++)
                                                {
                                                    Console.WriteLine($"{i + 1}. {teams[i].Name}");
                                                }
                                                int number_team = int.Parse(Console.ReadLine());
                                                int number_team_1 = int.Parse(Console.ReadLine());
                                                if ((teams[number_team - 1] != null) ^ (teams[number_team_1 - 1] != null))
                                                {
                                                    Console.WriteLine("You choosed uncorectly id of team");
                                                    break;
                                                }
                                                Console.WriteLine("Give data of this match, type like(30/06/2011):");
                                                string time = (Console.ReadLine());
                                                Console.WriteLine("Give name of the Tournament:");
                                                string name = (Console.ReadLine());
                                                Console.WriteLine("Give type of the game:");
                                                string type = (Console.ReadLine());
                                                bool pass = false;
                                                bool key = true;
                                                while (key == true)
                                                {
                                                    Console.WriteLine("Did this match pass?(yes/no)");
                                                    string isbe = (Console.ReadLine());
                                                    if (isbe == "yes")
                                                    {
                                                        pass = true;
                                                        key = false;
                                                    }
                                                    else
                                                    {
                                                        if (isbe == "no")
                                                        {
                                                            pass = false;
                                                            key = false;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("You wrote uncorrectly answer!!!");
                                                        }

                                                    }
                                                }
                                                if (pass == true)
                                                {
                                                    Console.WriteLine("Give finall score of first team");
                                                    int score1 = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("Give finall score of second team");
                                                    int score2 = int.Parse(Console.ReadLine());
                                                    past_history.AddtoHistory(new Match(teams[number_team - 1], teams[number_team_1 - 1], time, name, type, score1, score2));
                                                }
                                                else
                                                {
                                                    future_history.AddtoHistory(new Match(teams[number_team - 1], teams[number_team_1 - 1], time, name, type));
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine("Please write correctly!!!");
                                            }
                                            break;
                                        }

                                    default:
                                        flag_1 = false;
                                        break;
                                }
                            }
                            break;
                        }
                    case "2":
                        {
                            bool flag_2 = true;
                            while (flag_2)
                            {
                                Console.WriteLine("******************************\n");
                                Console.WriteLine("To show all player of team, write 1");
                                Console.WriteLine("To see schedule, write 2");
                                Console.WriteLine("Give matches info about a player, write 3");
                                Console.WriteLine("To see history, write 4");
                                Console.WriteLine("Give history and schedule of a team, write 5");
                                Console.WriteLine("To show all matches of current tournament, write 6");
                                Console.WriteLine("To show all matches of current type, write 7");
                                Console.WriteLine("To get back to the choose write anything");
                                var str = Console.ReadLine();
                                switch (str)
                                {
                                    case "1":
                                        {
                                            try
                                            {
                                                Console.WriteLine("Select the team, to show all player of current team");
                                                for (int i = 0; i < teams.Count; i++)
                                                {
                                                    Console.WriteLine($"{i + 1}. {teams[i].Name}");
                                                }
                                                int number_team = int.Parse(Console.ReadLine());
                                                if (teams[number_team - 1].Players.Count == 0)
                                                {
                                                    Console.WriteLine("There is no one.");
                                                    break;
                                                }
                                                foreach (var item in teams[number_team - 1].Players)
                                                {
                                                    Console.WriteLine($"Name: {item.First.Name} Id: {item.First.Id} Number: {item.Second}");
                                                }
                                                Console.WriteLine("You succesfully got a full list of players of current team");
                                                Console.WriteLine("*****************************\n");
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine("Please write correctly!!!");
                                            }
                                            break;
                                        }
                                    case "2":
                                        {
                                            try
                                            {
                                                int i = 1;
                                                foreach (var item in future_history.Future_Matches)
                                                {
                                                    Console.WriteLine($"Match {i}. {item.Team1.Name} VS {item.Team2.Name}  Tournament: {item.Name}  Time {item.Time}  Type {item.Type}");
                                                    i++;
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine("Please write correctly!!!");
                                            }
                                            break;
                                        }
                                    case "3":
                                        {
                                            try
                                            {
                                                Console.WriteLine("Write name of player to find his team and team matches");
                                                string name = Console.ReadLine();
                                                bool check, isexist = false;
                                                foreach (var item in teams)
                                                {
                                                    check = false;
                                                    foreach (var item1 in item.Players)
                                                    {
                                                        if (item1.First.Name == name)
                                                        {
                                                            Console.WriteLine(item.Name);
                                                            isexist = true;
                                                            check = true;

                                                        }
                                                    }
                                                    if (check == true)
                                                    {
                                                        int i = 1;
                                                        Console.WriteLine("Past mathes:");
                                                        foreach (var item2 in past_history.Past_Matches)
                                                        {
                                                            if (item2.Team1.Name == item.Name || item2.Team2.Name == item.Name)
                                                            {
                                                                Console.WriteLine($"Match {i}. {item2.Team1.Name} {item2.Score1} VS {item2.Score2} {item2.Team2.Name}  Tournament: {item2.Name} Type {item2.Type}  Time {item2.Time} ");
                                                                i++;
                                                            }

                                                        }
                                                        int y = 1;
                                                        Console.WriteLine("Future matches:");
                                                        foreach (var item2 in future_history.Future_Matches)
                                                        {
                                                            if (item2.Team1.Name == item.Name || item2.Team2.Name == item.Name)
                                                            {
                                                                Console.WriteLine($"Match {y}. {item2.Team1.Name} VS {item2.Team2.Name}   Tournament: {item2.Name} Type {item2.Type}  Time {item2.Time}");
                                                                y++;
                                                            }

                                                        }
                                                    }
                                                }
                                                if (isexist == false)
                                                {
                                                    Console.WriteLine("Didn`t find player with current name");
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine("Please write correctly!!!");
                                            }
                                            break;
                                        }
                                    case "4":
                                        {
                                            try
                                            {
                                                int i = 1;
                                                foreach (var item in past_history.Past_Matches)
                                                {
                                                    Console.WriteLine($"Match {i}. Team №1: {item.Team1.Name} {item.Score1} / Team №2: {item.Team2.Name} {item.Score2}/ Tournament: {item.Name} / Time {item.Time} / Type {item.Type} ");
                                                    i++;
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine("Please write correctly");
                                            }
                                            break;
                                        }
                                    case "5":
                                        {
                                            try
                                            {
                                                Console.WriteLine("Select the team to get info about");
                                                for (int t = 0; t < teams.Count; t++)
                                                {
                                                    Console.WriteLine($"{t + 1}. {teams[t].Name}");
                                                }
                                                int number_team = int.Parse(Console.ReadLine());
                                                int i = 1;
                                                foreach (var item2 in past_history.Past_Matches)
                                                {
                                                    if (item2.Team1.Name == teams[number_team - 1].Name || item2.Team2.Name == teams[number_team - 1].Name)
                                                    {
                                                        if (i == 1)
                                                        {
                                                            Console.WriteLine("Past mathes:");
                                                        }
                                                        Console.WriteLine($"Match {i}. {item2.Team1.Name} {item2.Score1} VS {item2.Score2} {item2.Team2.Name}  Tournament: {item2.Name} Type {item2.Type}  Time {item2.Time} ");
                                                        i++;
                                                    }

                                                }
                                                int y = 1;
                                                foreach (var item2 in future_history.Future_Matches)
                                                {
                                                    if (item2.Team1.Name == teams[number_team - 1].Name || item2.Team2.Name == teams[number_team - 1].Name)
                                                    {
                                                        if (y == 1)
                                                        {
                                                            Console.WriteLine("Future matches:");
                                                        }
                                                        Console.WriteLine($"Match {y}. {item2.Team1.Name} VS {item2.Team2.Name}   Tournament: {item2.Name} Type {item2.Type}  Time {item2.Time}");
                                                        y++;
                                                    }

                                                }
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine("Please write correctly!!!");
                                            }
                                            break;
                                        }
                                    case "6":
                                        {
                                            try
                                            {
                                                Console.WriteLine("Write a name of the tournament,which you need to find");
                                                string tour = Console.ReadLine();
                                                int i = 1;
                                                bool check = false;
                                                foreach (var item2 in past_history.Past_Matches)
                                                {
                                                    if (item2.Name == tour || item2.Name == tour)
                                                    {
                                                        if (i == 1)
                                                        {
                                                            Console.WriteLine("Past mathes:");
                                                        }
                                                        Console.WriteLine($"Match {i}. {item2.Team1.Name} {item2.Score1} VS {item2.Score2} {item2.Team2.Name}  Tournament: {item2.Name} Type {item2.Type}  Time {item2.Time} ");
                                                        i++;
                                                        check = true;
                                                    }

                                                }
                                                int y = 1;
                                                foreach (var item2 in future_history.Future_Matches)
                                                {
                                                    if (item2.Name == tour || item2.Name == tour)
                                                    {
                                                        if (y == 1)
                                                        {
                                                            Console.WriteLine("Future mathes:");
                                                        }
                                                        Console.WriteLine($"Match {y}. {item2.Team1.Name} VS {item2.Team2.Name}   Tournament: {item2.Name} Type {item2.Type}  Time {item2.Time}");
                                                        y++;
                                                        check = true;
                                                    }

                                                }
                                                if (check == false)
                                                {
                                                    Console.WriteLine("No tournament with this title!!!");
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine("Please write correctly!!!");
                                            }
                                            break;
                                        }
                                    case "7":
                                        {
                                            try
                                            {
                                                Console.WriteLine("Write a type of games to get all matches with this type");
                                                string tour = Console.ReadLine();
                                                int i = 1;
                                                bool check = false;
                                                foreach (var item2 in past_history.Past_Matches)
                                                {
                                                    if (item2.Type == tour || item2.Type == tour)
                                                    {
                                                        if (i == 1)
                                                        {
                                                            Console.WriteLine("Past mathes:");
                                                        }
                                                        Console.WriteLine($"Match {i}. {item2.Team1.Name} {item2.Score1} VS {item2.Score2} {item2.Team2.Name}  Tournament: {item2.Name} Type {item2.Type}  Time {item2.Time} ");
                                                        i++;
                                                        check = true;
                                                    }

                                                }
                                                int y = 1;
                                                foreach (var item2 in future_history.Future_Matches)
                                                {
                                                    if (item2.Type == tour || item2.Type == tour)
                                                    {
                                                        if (y == 1)
                                                        {
                                                            Console.WriteLine("Future mathes:");
                                                        }
                                                        Console.WriteLine($"Match {y}. {item2.Team1.Name} VS {item2.Team2.Name}   Tournament: {item2.Name} Type {item2.Type}  Time {item2.Time}");
                                                        y++;
                                                        check = true;
                                                    }

                                                }
                                                if (check == false)
                                                {
                                                    Console.WriteLine("Didn`t find type with this title!!!");
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine("Please write correctly!!!");
                                            }
                                            break;
                                        }
                                    default:
                                        flag_2 = false;
                                        break;
                                }
                            }
                            break;
                        }
                    
                    default:
                        flag_choose = false;
                        break;
                }
            }

            static void CreateTeam()
            {
                Console.WriteLine("To create a team write Title of it: ");
                string name = Console.ReadLine();
                foreach (var item in teams)
                {
                    if (item.Name == name)
                    {
                        Console.WriteLine($"Team with title {name} already exists");
                        return;
                    }
                }
                teams.Add(new Team(name));
            }
            static void DisplayMessage(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
