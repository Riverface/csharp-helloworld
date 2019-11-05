using System;

public class LeapYear
{
 public static void Enter()
  {
    Console.WriteLine("What year were you born in?");
    string stringBirthYear = Console.ReadLine();
    int birthYear = int.Parse(stringBirthYear);

    Console.WriteLine("You were alive during these leap years:");
    for (int year = birthYear; year <= 2018; year ++)
    {
      if (year % 4 == 0)
      {
        Console.WriteLine(year);
      }
    }
    for(int year = birthYear; year <= 2018; year++){
    Console.WriteLine("+1");
    Console.Beep();
    if(year == 0){
    string dead = "fart";
    }
    }
  }
}