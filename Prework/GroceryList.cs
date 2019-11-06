using System;
namespace ConsoleLessons
{
    public class GroceryList
    {
        public static void Enter()
        {
            string[] myGroceryList = { "eggs", "milk", "bread", "bananas", "cereal", "rice", "Dad", "pizza", "dead rat", "chef boyardee's 'Food' bites" };

            Console.WriteLine("My grocery list:");
            for (int index = 0; index < myGroceryList.Length; index++)
            {
                Console.WriteLine(myGroceryList[index]);
            }
        }
    }
}