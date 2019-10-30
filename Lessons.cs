using System;
using static MealTime;
using static Program;
using static DoubleIt;
   

public class Lessons
{
  static void Main()
  {
    int state = 0;

    Console.WriteLine("Tell me which lesson you'd like!");
    Console.WriteLine("1.) Hello world!");
    Console.WriteLine("2.) Number Doubler!");
    Console.WriteLine("3.) MealTime!");
    state = System.Convert.ToInt32(Console.ReadLine()); 
    if(state == 1){
    Program.Enter();
    }
    if(state == 2){
    DoubleIt.Enter();
    }
    if(state == 3){
      MealTime.Enter();
    }
  }
}