using System;
using System.Collections.Generic;
namespace ConsoleLessons
{
    public class Car
    {
        private string _MakeModel;
        private int _Price;
        private int _Miles;
        public static string MakeSound(string sound){
            return "Our cars sound like" + sound;
        }
        public Car(string makeModel, int price, int miles)
        {
            _MakeModel = makeModel;
            _Price = price;
            _Miles = miles;
        }

        public bool WorthBuying(int maxPrice)
        {
            return (_Price < maxPrice);
        }
        public bool WorthDriving(int maxMiles)
        {
            return (_Miles < maxMiles);
        }
        public string GetMakeModel()
        {
            return _MakeModel;
        }
    }
    public class CarProg
    {
        public static void Enter()
        {
            Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
            Car yugo = new Car("1980 Yugo Koral", 700, 56000);
            Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
            Car amc = new Car("1976 AMC Pacer", 400, 198000);

            List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

            Console.WriteLine("Enter maximum price: ");
            string stringMaxPrice = Console.ReadLine();
            Console.WriteLine("Enter maximum miles: ");
            string stringMaxMiles = Console.ReadLine();
            int maxPrice = int.Parse(stringMaxPrice);
            int maxMiles = int.Parse(stringMaxMiles);
            int listlength = 0;
            List<Car> CarsMatchingSearch = new List<Car>(0);
            foreach (Car automobile in Cars)
            {
                if (automobile.WorthBuying(maxPrice))
                {
                    if (automobile.WorthDriving(maxMiles))
                    {

                        CarsMatchingSearch.Add(automobile);
                        listlength++;
                    }
                }


            }
            foreach (Car automobile in CarsMatchingSearch)
            {
                if (automobile.WorthBuying(maxPrice))
                {
                    if (automobile.WorthDriving(maxMiles))
                    {

                        Console.WriteLine(automobile.GetMakeModel());
                    }

                }

            }
            if (listlength == 0)
            {

                Console.WriteLine("No entries!");
            }

        }
    }
}