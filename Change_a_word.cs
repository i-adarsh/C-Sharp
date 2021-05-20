using System;

// namespace Sonu{
    public class Adarsh{
        public static void Main(){
            Console.WriteLine("Enter a string");
            string msg = Console.ReadLine();
            string [] str = (string[])msg.Split(' ');
            if (msg.Contains("the")){
                for (int i = 0; i < str.Length; i++){
                    if(str[i] == "the"){
                        Console.Write("that ");
                    }
                    else{
                        Console.Write(str[i] + " ");
                    }
                }
            }
            else{
                Console.WriteLine("Word 'the' not found");
            }
        }
    }
// }