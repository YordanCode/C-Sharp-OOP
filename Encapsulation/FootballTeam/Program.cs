using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeam;
class Program
{
    static void Main()
    {
        List<Team> teams = new();
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] tokens = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
            string command = tokens[0];
            try
            {
                if (command == "Team")
                    teams.Add(new Team(tokens[1]));
                else if (command == "Add")
                {
                    Team team = teams.FirstOrDefault(t => t.Name == tokens[1]);
                    if (team != null)
                    {
                        Player player = new(tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4])
                            , int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7]));
                        team.AddPlayer(player);
                    }
                    else
                        Console.WriteLine($"Team {tokens[1]} does not exist.");
                }
                else if (command == "Remove")
                {
                    Team team = teams.FirstOrDefault(t => t.Name == tokens[1]);
                    if (team != null)
                    {
                        if (team.RemovePlayer(tokens[2]) == false)
                            Console.WriteLine($"Player {tokens[2]} is not in {tokens[1]} team.");
                        else
                            team.RemovePlayer(tokens[2]);
                    }
                    else
                    {
                        Console.WriteLine($"Team {tokens[1]} does not exist.");

                    }
                }
                else if (command == "Rating")
                {
                    Team team = teams.FirstOrDefault(t => t.Name == tokens[1]);
                    if (team != null)
                        Console.WriteLine($"{tokens[1]} - {team.Rating}");
                    else
                        Console.WriteLine($"Team {tokens[1]} does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}