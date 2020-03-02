using System;
using System.Collections.Generic;

namespace HeistPlan
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan your heist!");
      Console.WriteLine("What is the difficulty level of the bank you are robbing?");
      int bankDifficulty = int.Parse(Console.ReadLine());

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

      Console.WriteLine("How many trial runs would you like to undergo?");
      int trialRuns = int.Parse(Console.ReadLine());

      int failedAttempts = 0;
      int successfulAttempts = 0;

      int randomLuck = new Random().Next(-10, 11);
      int successRate = bankDifficulty + randomLuck;

      int overallSkill = 0;

      foreach (Dictionary<string, string> member in team)
      {
        int playerSkill = int.Parse(member["skill level"]);
        overallSkill += playerSkill;
      }

      Console.WriteLine($"The bank's level of difficulty is {successRate}.");
      Console.WriteLine($"Your team's overall skill level is {overallSkill}.");

      if (bankDifficulty > overallSkill)
      {
        Console.WriteLine("Fail!");
      }
      else
      {
        Console.WriteLine("Success!");
      }
    }
  }
}
