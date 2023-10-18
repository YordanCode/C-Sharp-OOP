using BorderControl.Models;
using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace BorderControl;
public class StartUp
{
    static void Main()
    {
        List<IIdentifiable> society = new List<IIdentifiable>();
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 2)
            {
                Robot robot = new(tokens[0], tokens[1]);
                society.Add(robot);
            }
            else if (tokens.Length == 3)
            {
                Citizen citizen = new(tokens[0], int.Parse(tokens[1]), tokens[2]);
                society.Add(citizen);
            }
        }
        string InvalidSuffix = Console.ReadLine();
        foreach (var element in society)
        {
            if (element.Id.EndsWith(InvalidSuffix))
            Console.WriteLine(element.Id);
        }
    }
}
