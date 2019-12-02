using System;
namespace ConsoleLessons
{
public class Palindrome
{
    public static void Enter()
    {
        string inp = Console.ReadLine();
        char[] inpArr = inp.ToCharArray();
        Array.Reverse(inpArr);
        string newArr = new String(inpArr);
        
        if (inp == newArr)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("No");
        }
        
    }
}
}   