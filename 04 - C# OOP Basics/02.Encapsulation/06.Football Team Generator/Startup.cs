namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var teams = new Dictionary<string, Team>();
            string inputLine;

            while ((inputLine = Console.ReadLine()) != "END")
            {
                try
                {
                    var tokens = inputLine.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                    switch (tokens[0])
                    {
                        case "Team":
                            var team = new Team(tokens[1]);
                            teams.Add(team.Name, team);
                            break;
                        case "Add":
                            AddPlayerToTeam(teams, tokens);
                            break;
                        case "Remove":
                            teams[tokens[1]].RemovePlayer(tokens[2]);
                            break;
                        case "Rating":
                            ShowRating(teams, tokens[1]);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void ShowRating(Dictionary<string, Team> teams, string teamsName)
        {
            if (!teams.ContainsKey(teamsName))
            {
                throw new InvalidOperationException($"Team {teamsName} does not exist.");
            }
            var rating = teams[teamsName].GetRate();
            Console.WriteLine($"{teamsName} - {rating:f0}");
        }

        private static void AddPlayerToTeam(Dictionary<string, Team> teams, string[] tokens)
        {
            if (!teams.ContainsKey(tokens[1]))
            {
                throw new InvalidOperationException($"Team {tokens[1]} does not exist.");
            }
            var stats = new Stats(
                int.Parse(tokens[3]),
                int.Parse(tokens[4]),
                int.Parse(tokens[5]),
                int.Parse(tokens[6]),
                int.Parse(tokens[7]));
            var player = new Player(tokens[2], stats);
            teams[tokens[1]].AddPlayer(player);
        }
    }
}