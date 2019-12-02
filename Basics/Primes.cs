using System;
namespace ConsoleLessons{
    public class Primes{
        static public void Enter(){
            Console.WriteLine("Enter a number!");
            Console.WriteLine("All primes under this number will be displayed.");
            int input = System.Convert.ToInt32(Console.ReadLine());
            Feed(input);
        }
        static public void Feed(int input){
            for (int o = 0; o < input; o++){
                Process(o);
            }
        }
        static public void Process(int input){
            int n, i, m = 0, flag = 0;
            n = input;
            m = n / 2;
            for (i = 2; i <= m; i++){
                if (n % i == 0){
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine(n+ " is Prime.");
            }
        }
    }
}