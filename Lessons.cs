using System;
using static MealTime;
using static Program;
using static DoubleIt;
using static RatedR;
using static HotelCost;

public class Lessons
{
    static int state = 0;
    public static void Main()
    {

        Projmenu();


    }
    public static void Projmenu()
    {
        Console.WriteLine("Tell me which lesson you'd like!");
        Console.WriteLine("1.) Hello world!");
        Console.WriteLine("Just says hi to ya.");
        Console.WriteLine("2.) Number Doubler!");
        Console.WriteLine("Returns double the number you put in.");
        Console.WriteLine("3.) MealTime!");
        Console.WriteLine("Asks what you had for meals, tells you what you told it after.");
        Console.WriteLine("4.)RatedR(Z?)");
        Console.WriteLine("Asks your name, then tells you whether or not there's a Z in it.");
        Console.WriteLine("5.) Hotel Cost");
        Console.WriteLine("Asks what season you're booking a hotel in and if you're booking on weekends.");
        Lessons.state = System.Convert.ToInt32(Console.ReadLine());
        switch (Lessons.state)
        {
            case 1:
                Program.Enter();
                break;
            case 2:
                DoubleIt.Enter();
                break;
            case 3:
                MealTime.Enter();
                break;
            case 4:
                RatedR.Enter();
                break;
            case 5:
                HotelCost.Enter();
                break;
        }

    }
    public static void Pause(){
      Console.WriteLine("...And that's the program. Press any key to continue back to the main menu.");
      Console.ReadKey();
      Lessons.Projmenu();
    }
}