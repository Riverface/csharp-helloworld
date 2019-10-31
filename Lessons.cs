using System;
using static MealTime;
using static Program;
using static DoubleIt;
using static RatedR;
using static HotelCost;
using static LeapYear;
using static GroceryList;

public class Lessons
{
    static string state = "";
    static int lesson = 0;
    public static void Main()
    {

        Projmenu();


    }
    public static void Projmenu()
    {

        Console.WriteLine("Press a key to continue when the application pauses.");
        Console.WriteLine("Ok?");
        Console.ReadKey();
        Console.WriteLine("Great! Here are the projects. Press a number and Press Enter to select one.");
        Console.WriteLine("1.) Hello world!");
        Console.WriteLine("Just says hi to ya.");
        Console.ReadKey();
        Console.WriteLine("2.) Number Doubler!");
        Console.WriteLine("Returns double the number you put in.");
        Console.ReadKey();
        Console.WriteLine("3.) MealTime!");
        Console.WriteLine("Asks what you had for meals, tells you what you told it after.");
        Console.ReadKey();
        Console.WriteLine("4.)RatedR(Z?)");
        Console.WriteLine("Asks your name, then tells you whether or not there's a Z in it.");
        Console.ReadKey();
        Console.WriteLine("5.) Hotel Cost");
        Console.WriteLine("Asks what season you're booking a hotel in and if you're booking on weekends.");
        Console.ReadKey();
        Console.WriteLine("6.) Leap Year");
        Console.WriteLine("Tell the program your birth year and it will tell you how many leap years you've been alive.");
        Console.ReadKey();
        Console.WriteLine("6.) Leap Year");
        Console.WriteLine("Returns a list of groceries.");
        Lessons.state = Console.ReadLine();
        if (Lessons.state != "" )
        {
            Lessons.lesson = System.Convert.ToInt32(Lessons.state);
        }
        Selection();
    }
    public static void Pause()
    {
        Console.WriteLine("...And that's the program. Press any key to continue back to the main menu.");
        Console.ReadKey();
        Lessons.Projmenu();
        Console.Beep();
    }
    public static void Selection()
    {

        switch (Lessons.lesson)
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
            case 6:
                LeapYear.Enter();
                break;
            case 7:
                GroceryList.Enter();
                break;
            default:
                Console.WriteLine("What?");
                Projmenu();
                break;
        }
    }
}