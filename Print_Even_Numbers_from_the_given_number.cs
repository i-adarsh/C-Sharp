using System;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            Console.Write("Enter starting number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            number = number + 1;
            while(count < 10){
                if (number % 2 == 0){
                    Console.Write("{0} ", number);
                    count++;
                }
                number++;
            }
        }
    }
}