using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Country : ");
            string city = Console.ReadLine();

            Console.Write("Welcome {0}. Your age is {1} and you are from {2}", name, age, city);
        }
    }
}