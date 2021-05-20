using System;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            char [] words = new char[12];
            char [] s1 = "Adarsh Kumar".ToCharArray();
            for (int i = 0; i < words.Length; i++){
                Console.Write("Enter letter {0} : ", (i + 1));
                words[i] = Console.ReadLine()[0];
            }
            for (int i = 0; i < s1.Length; i++){
                if (words[i] == s1[i]){
                    Console.WriteLine("Enter letter {0} : {1}", (i + 1), words[i]);
                }
                else{
                    Console.WriteLine("The spelling is wrong");
                }
            }
        }
    }
}