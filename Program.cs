using System;
using System.Collections.Generic;
using Sphinx.Models;

namespace Sphinx {

  public class Program
  {
    public static void Main()
    {
      Riddle RiddleOne = new Riddle("I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?", "fire");
      Riddle RiddleTwo = new Riddle("What runs around the whole yard without moving?","a fence");
      Riddle RiddleThree = new Riddle("What can you catch but never throw?", "a cold");

      List<Riddle> SphinxRiddles = new List<Riddle>() {RiddleOne,RiddleTwo,RiddleThree};

      Console.WriteLine("Welcome to the great and powerful Cyber Sphinx. I will ask you three riddles in succession. Answer poorly, and you DIE! Begin? [y] - yes, [n] - no");
      string begin = Console.ReadLine();
      if (begin == "y" || begin == "Y")
      {
        Console.WriteLine("Good. Let's begin.");
        Console.WriteLine(RiddleOne.Question);
      }
      else
      {
        Console.WriteLine("Farewell.");
      }
    }
  }
}