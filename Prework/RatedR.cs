using System;
namespace ConsoleLessons
{
    public class RatedR
    {
        public static void Enter()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            if (userName.StartsWith("Z"))
            {
                Console.WriteLine("Your name starts with a Z!");
            }
            else
            {
                Console.WriteLine("Your name doesn't start with a Z :(");
            }
            Lessons.Pause();
        }
    }
}