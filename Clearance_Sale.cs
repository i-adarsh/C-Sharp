using System;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            Console.WriteLine("Enter the name of the product :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the price of the product :");
            float price = Single.Parse(Console.ReadLine());
            Console.WriteLine("Is the product on SALE (yes/no) :");
            string sale = Console.ReadLine();
            Console.WriteLine("Enter number of product sold in day 1");
            int day1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 2");
            int day2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 3");
            int day3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}", name);
            if (sale == "yes"){
                price = price - (price * .07f);
                day1 = (int)(price * day1);
                price = price - (price * .07f);
                day2 = (int)(price * day2);
                price = price - (price * .07f);
                day3 = (int)(price * day3);
            }
            else{
                day1 = (int)price * day1;
                day2 = (int)price * day2;
                day3 = (int)price * day3;
            }
            Console.WriteLine("Day 1 sales total : {0}", day1);
            Console.WriteLine("Day 2 sales total : {0}", day2);
            Console.WriteLine("Day 3 sales total : {0}", day3);
        }
    }
}