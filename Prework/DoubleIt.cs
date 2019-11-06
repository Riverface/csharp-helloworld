using System;
namespace ConsoleLessons
{
    public class DoubleIt
    {
        public static void Enter()
        {
            Console.WriteLine("Give me a number, and I will double it for you!");
            string stringNumber = Console.ReadLine();  // <-- New code
            int yourNumber = int.Parse(stringNumber);  // <-- New code
            int yourDoubledNumber = yourNumber * 2;
            string stringDoubledNumber = yourDoubledNumber.ToString();  // <-- New code
            Console.WriteLine("I doubled your number for you: " + stringDoubledNumber);
            ConsoleLessons.Lessons.Pause();
        }
    }
}