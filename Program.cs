using System;
using System.Collections.Generic;

namespace HeistPlan
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan your heist!");

      List<Dictionary<string, string>> team = new List<Dictionary<string, string>>();

      while (true)
      {
        Dictionary<string, string> player = new Dictionary<string, string>();

        Console.WriteLine("What is the name of your new player?");
        string playerName = Console.ReadLine();
        if (playerName == "")
        {
          break;
        }
        player.Add("name", playerName);

        Console.WriteLine("What is this player's skill level between 0 and 100?");
        string playerSkill = Console.ReadLine();
        player.Add("skill level", playerSkill);

        Console.WriteLine("What is the new team member's courage level between 0 and 2?");
        string playerCourage = Console.ReadLine();
        player.Add("courage factor", playerCourage);

        team.Add(player);
      }

      Console.WriteLine($"Congrats! Your team now has {team.Count} members!");

      foreach (Dictionary<string, string> member in team)
      {
        foreach (KeyValuePair<string, string> facts in member)
        {
          Console.WriteLine($"The {facts.Key} is {facts.Value}.");
        }
      }
    }
  }
}
