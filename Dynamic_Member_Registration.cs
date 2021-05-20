using System;
using System.Collections.Generic;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            List<string> names = new List<string>();
            List<string> places = new List<string>();
            List<char> status = new List<char>();

            char choice = 'y';
            while(choice == 'y'){
                Console.Write("Enter Name : ");
                names.Add(Console.ReadLine());
                Console.Write("Enter Place : ");
                places.Add(Console.ReadLine());
                Console.Write("Enter marital status(y/n) : ");
                status.Add(Console.ReadLine()[0]);
                Console.Write("Do you wish to continue(y/n) : ");
                choice = Console.ReadLine()[0];
                Console.WriteLine();
            }
            for (int i = 0; i <names.Count; i++){
                Console.WriteLine("Confirming Information");
                Console.WriteLine("{0}", names[i]);
                Console.WriteLine("{0}", places[i]);
                Console.WriteLine("Married : {0}", status[i]);
                Console.WriteLine();
            }
        }
    }
}