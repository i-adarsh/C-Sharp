using System;

public class Adarsh{
    public static void Main(){
        Console.WriteLine("Enter any alphabet");
        char alphabet = Console.ReadLine()[0];
        Console.WriteLine("Enter number of repeats :");
        int rows = Convert.ToInt32(Console.ReadLine());
        int k = 0;
        for (int i = 1; i <= rows; ++i, k = 0) {
            for (int space = 1; space <= rows - i; ++space) {
                Console.Write("  ");
            }

        while (k != 2 * i - 1) {
        Console.Write(alphabet + " ");
        ++k;
        }
        Console.WriteLine();
    }
    }
}