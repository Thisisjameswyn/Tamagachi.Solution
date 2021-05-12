using System.Collections.Generic;
using System;

namespace Tamagotchis.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }
    int hunger = 10;
    int stamina = 10;
    public int Id { get; }
    private static List<Tamagotchi> _instances = new List<Tamagotchi> { };

    public Tamagotchi(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Tamagotchi> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Tamagotchi Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public void FeedMe()
    {
      this.hunger += 1;
      Console.WriteLine("Triggered!");
      DecreaseStats();
    }

    public void Sleep()
    {
      this.stamina += 1;
      DecreaseStats();
    }

    private static void DecreaseStats()
    {
      foreach (Tamagotchi gotchi in _instances)
      {
        gotchi.hunger -= 1;
        gotchi.stamina -= 1;
      }
    }
  }
}