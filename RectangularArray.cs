using System;

public class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int [,] matrix = GetArray(num);
        for (int i = 0; i < num; i++){
            for (int j = 0; j < num; j++){
                Console.Write(matrix[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }
    public static int[,] GetArray(int num){
        int [,] matrix = new int [num, num];
        for (int i = 0; i < num; i++){
            for (int j = 0; j < num; j++){
                if (i == j){
                    matrix[i,j] = 0;
                }
                else if(i < j){
                    matrix[i,j] = 1;
                }
                else{
                    matrix[i,j] = -1;
                }
            }
        }
        return matrix;
    }
}