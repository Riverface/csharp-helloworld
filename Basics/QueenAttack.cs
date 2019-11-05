using System;
using static BasicsMenu;
public class QueenAttack
{
    public static string[] move1, move2 = new string[2];
    public static int diffx;
    public static int diffy;
    public static int length = 3;
    public static void Enter()
    {

        Console.WriteLine("This program checks to see if a Chess move works, from the perspective of a Queen piece.");
        Console.WriteLine("Enter 2 numbers, like this: 0,0");

        Console.WriteLine("Enter Coordinate 1:");
        move1 = Console.ReadLine().Split(",");
        Console.WriteLine("Enter Coordinate 2:");

        move2 = Console.ReadLine().Split(",");

        diffx = System.Math.Abs(int.Parse(move1[0]) - int.Parse(move2[0]));
        diffy = System.Math.Abs(int.Parse(move1[1])  - int.Parse(move2[1]));
        if (diffy == diffx){
            Console.WriteLine("It's viable!");
        }
        else{
            Console.WriteLine("It's not viable!");
        }
        BasicsMenu.Enter();
    }
}