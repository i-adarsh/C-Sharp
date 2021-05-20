using System;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            Console.WriteLine("Enter a string");
            string msg = Console.ReadLine();
            string str = (string[])msg.Split(' ');
            if (str.Contains('the')){
                Console.WriteLine("True");
            }
            else{
                Console.WriteLine("False");
            }
        }
    }
}