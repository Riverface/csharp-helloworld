using System;

public class MainProgram
{
    public static string state = "";
    public static int select = 0;
    public static void Main()
    {
        mainmenu();
    }
    public static void mainmenu()
    {
    Console.WriteLine("1.) Pre-work)");
    Console.WriteLine("Really simple console stuff.");
    Console.WriteLine("2.) C# Basics Examples");
    Console.WriteLine("3.) C# Basics");
    Console.WriteLine("A little more complex. Mostly actual stuff I coded rather than more-or-less copypasting and observing.");
    state = Console.ReadLine();
    Selection();
    }
    public static void Selection()
    {
        select = System.Convert.ToInt32(state);
        switch (MainProgram.select)
        {
            case 1:
                Lessons.Enter();
                break;
            case 2:
                BasicsMenu.Enter();
                break;
                default:
                mainmenu();
                break;
        }
    }
}