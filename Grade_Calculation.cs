using System;

namespace Sonu{
    public class Adarsh{
        public static string Marks (int marks){
                if (marks >= 80 && marks <= 100){
                    return "A+";
                }
                else if (marks >= 60 && marks <= 80){
                    return "A";
                }
                else if(marks >= 40 && marks <= 60){
                    return "B";
                }
                else {
                    return "FAIL";
                }
            }
        public static void Main(string [] args){
            Console.WriteLine("Enter English marks : ");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Math marks : ");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Language marks : ");
            int language = Convert.ToInt32(Console.ReadLine());
            
            if (english > 0){
                Console.WriteLine("English Grade : {0}", Marks(english));
                if (math > 0){
                    Console.WriteLine("Math Grade : {0}", Marks(math));
                    if (language > 0){
                        Console.WriteLine("Language Grade : {0}", Marks(language));
                    }
                    else{
                        Console.WriteLine("Marks cannot be less than 0");
                    }
                }
                else{
                    Console.WriteLine("Marks cannot be less than 0");
                }
            }
            else{
                Console.WriteLine("Marks cannot be less than 0");
            }
        }
    }
}