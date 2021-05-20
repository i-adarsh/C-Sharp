using System;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            List<Integer> marks = new List<Integer>();
            char choice = 'y';
            while(choice == 'y'){
                Console.Write("Enter Your Number : ");
                int a = Convert.ToInt32(Console.ReadLine());
                marks.add(a);
                Console.Write("Do you want to continue (y/n):");
                choice = Console.ReadLine()[0];
            }
            for (int i = 0; i < marks.sise(); i++){
                Console.Write("{0} ", marks[i]);
            }
        }
    }
}