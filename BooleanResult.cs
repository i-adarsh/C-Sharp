using System;
namespace Sonu{
    public class Adarsh{
        public static void Main(){
            Console.Write("Enter the value for x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value for y");
            int y = Convert.ToInt32(Console.ReadLine());
            string s;
            if (x < y){
                s = "true";
            }
            else{
                s = "false";
            }
            Console.Write("x is less than y is {0}", s);
        }
    }
}