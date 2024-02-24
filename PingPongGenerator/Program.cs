using System;
using PingPongGenerator.Models;
using Console = Colorful.Console;
using System.Drawing;
using System.Threading;

namespace PingPongGenerator
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Ping Pong Generator app!");
      Console.WriteLine("We'll replace numbers dividable by 3, 5, and 15 with Ping Pong strings.");
      Console.WriteLine("Please enter a number greater than 1: ");
      string userInput = Console.ReadLine();  
      
      try 
      {
        int input = int.Parse(userInput);
        PingPong pingPong = new PingPong(input);
        GetResult(pingPong);
      }
      catch (Exception ex)
      {
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.ForegroundColor = Color.Red;
        Console.WriteLine("ERROR: {0}", ex.Message);
        Console.WriteLine("Please only enter in numbers! Special symbols and alphabetic characters will not be accepted.");
        Console.ResetColor();
        Console.WriteLine("Please try again...");
        Main();
      }
    }

    static void GetResult(PingPong pingPong)
    {
      object[] result = pingPong.InsertString();
      Console.WriteLine("-----------------------------------------");
      for (int i = 0; i < result.Length; i++) 
      {
        object obj = result[i];
        {
          if (obj is int)
          {
            Console.WriteLine((int)obj);
          }
          else if (obj is string)
          {
            Console.WriteLine((string)obj);
          }
        }
        Thread.Sleep(250);
      }
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Please enter 'AGAIN' to generate new numbers. Enter anything else to exit.");
      string userResponse = Console.ReadLine(); 
      userResponse = userResponse.ToUpper();
      if (userResponse == "AGAIN")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Thanks for playing, goodbye! :)");
      }
    }
  }
}