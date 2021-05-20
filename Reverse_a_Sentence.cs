using System;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            Console.WriteLine("Enter a string");
            string s1 = Console.ReadLine();
            String [] str = (string[])s1.Split(' ');
            Array.Reverse(str);
            for (int i = 0; i < str.Length; i++){
                Console.Write(str[i] + " ");
            }
        }
    }
}