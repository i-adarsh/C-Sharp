using System;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            Console.Write("Number of Rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of Symbols : ");
            int symbols = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < (2 * row - 1); i++){
                if (i % 2 == 0){
                    for (int j = 0; j < symbols; j++){
                    Console.Write("/\\");
                    }
                Console.WriteLine();
                }
                if (i % 2 != 0){
                    for (int k = 0; k < (2 * symbols - 1); k++){
                        if (k == 0){
                            Console.Write("|");
                        }
                        if (k != 0){
                            Console.Write(" ");
                        }
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
                
            }
        }
    }
}