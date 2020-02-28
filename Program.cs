using System;
using System.Collections.Generic;

namespace HeistPlan
{
  class Program
  {
    static void Main(string[] args)
    {
      // Phase One

      Console.WriteLine("Plan your heist!");

      Dictionary<string, string> player = new Dictionary<string, string>();

      Console.WriteLine("What is the name of your new player?");
      string playerNameInput = Console.ReadLine();

      Console.WriteLine("What is this player's skill level between 0 and 100?");
      string playerSkillInput = Console.ReadLine();

      Console.WriteLine("What is the new team member's courage level between 0 and 2?");
      string playerCourageInput = Console.ReadLine();

      player.Add("name", playerNameInput);
      player.Add("skill level", playerSkillInput);
      player.Add("courage factor", playerCourageInput);

      Console.WriteLine("Congrats! You've successfully created a new player!");

      foreach (KeyValuePair<string, string> facts in player)
      {
        Console.WriteLine($"The {facts.Key} is {facts.Value}.");
      }
    }
  }
}
