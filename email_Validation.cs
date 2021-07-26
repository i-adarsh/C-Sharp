using System;


public class Program{
    public static void Main(){
        Console.Write("Enter a word: ");
        string s = Console.ReadLine();
        char [] charArr = s.ToCharArray();
        for (int i = 0; i <s.Length; i++){
            Console.WriteLine("{0}", s[i]);
            if (s[i] == '@'){
                Console.WriteLine("Hello");
            }
            Console.WriteLine("{0}", charArr[i]);
        }
    }
}