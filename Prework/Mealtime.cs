using System;
namespace ConsoleLessons
{
public class MealTime
{
  public static void Enter()
  {
    AskWhatYouAteFor("breakfast");
    AskWhatYouAteFor("lunch");
    AskWhatYouAteFor("dinner");
    Lessons.Pause();
  }

  public static void AskWhatYouAteFor(string meal)
  {
    Console.WriteLine("What did you eat for " + meal + "?");
    string yourMeal = Console.ReadLine();
    Console.WriteLine("You had " + yourMeal + " for " + meal + ".");
  
  }
}
}