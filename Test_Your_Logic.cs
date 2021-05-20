using System;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            Console.Write("Number of Symbols : ");
            int symbols = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < symbols; i++){
                Console.Write("/\\");
            }
            
        }
    }
}