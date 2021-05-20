using System;
using System.Collections.Generic;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            List<int> marks = new List<int>();
            char choice = 'y';
            while(choice == 'y'){
                Console.Write("Enter Your Number : ");
                int a = Convert.ToInt32(Console.ReadLine());
                marks.Add(a);
                Console.Write("Do you want to continue (y/n):");
                choice = Console.ReadLine()[0];
            }
            for (int i = 0; i < marks.Count; i++){
                Console.Write("{0} ", marks[i]);
            }
        }
    }
}