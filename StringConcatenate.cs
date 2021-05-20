using System; 

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            Console.WriteLine("Enter first name");
            String s1 = Console.ReadLine();
            Console.WriteLine("Enter last name");
            String s2 = Console.ReadLine();
            Console.WriteLine("Full name : {0}", (s1 + " " + s2));
        }
    }
}