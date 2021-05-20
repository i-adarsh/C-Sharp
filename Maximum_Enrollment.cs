using System;
using System.Collections.Generic;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            Console.Write("Total students placed in CS : ");
            int cs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter students placed in MECH : ");
            int mech = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter students placed in MET : ");
            int met = Convert.ToInt32(Console.ReadLine());

            int max = Math.max(Math.max(cs, mech), met);
            if (max == cs){
                Console.WriteLine("Highest placement CS");
            }
            if (max == mech){
                Console.WriteLine("Highest placement MECH")
            }
            if (max == met){
                Console.WriteLine("Highest placement MET");
            }
        }
    }
}