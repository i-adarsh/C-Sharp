using System;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            Console.Write("Enter name ");
            string name = Console.ReadLine();
            Console.Write("Enter age(completed years and months )");
            float age = Single.Parse(Console.ReadLine());
            Console.Write("Enter gender('M' for Male and 'F' for female )");
            char gender = Console.ReadLine()[0];
            Console.Write("Enter city ");
            string city = Console.ReadLine();
            Console.Write("Enter mobile number ");
            string mobile = Console.ReadLine();
            Console.Write("Enter pincode ");
            string pincode = Console.ReadLine();

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("City: {0}", city);
            Console.WriteLine("Mobile: {0}", mobile);
            Console.WriteLine("Pincode: {0}", pincode);
        }
    }
}