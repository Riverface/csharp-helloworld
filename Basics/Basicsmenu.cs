using System;
namespace ConsoleLessons
{
    public class BasicsMenu
    {
        static string state = "";
        static int lesson = 0;
        public static void Enter()
        {

            BMenu();


        }
        public static void BMenu()
        {

            Console.WriteLine("Press a key to continue when the application pauses.");
            Console.WriteLine("Ok?");
            Console.ReadKey();
            Console.WriteLine("Great! Here are the projects. Press a number and Press Enter to select one.");
            Console.WriteLine("1.) Queen Attack!");
            Console.WriteLine("Evaluates the chess move of a Queen to determine its validity.");
            Console.ReadKey();
            Console.WriteLine("2.)Car");
            Console.WriteLine("Search for cars.");
            Console.ReadKey();
            Console.WriteLine("3.)Palindrome");
            Console.WriteLine("Check if a word or sentence is a palindrome");
            BasicsMenu.state = Console.ReadLine();
            if (BasicsMenu.state != "")
            {
                BasicsMenu.lesson = System.Convert.ToInt32(BasicsMenu.state);
            }
            Selection();
        }
        public static void Pause()
        {
            Console.WriteLine("...And that's the program. Press any key to continue back to the main menu.");
            Console.ReadKey();
            BasicsMenu.BMenu();
            Console.Beep();
        }
        public static void Selection()
        {

            switch (ConsoleLessons.BasicsMenu.lesson)
            {
                case 1:
                    QueenAttack.Enter();
                    break;
                case 2:
                    CarProg.Enter();
                    break;
                case 3:
                    Palindrome.Enter();
                    break;
                    case 4:
                    Primes.Enter();
                    break;
                default:
                    Console.WriteLine("What?");
                    BMenu();
                    break;
            }
        }
    }
}