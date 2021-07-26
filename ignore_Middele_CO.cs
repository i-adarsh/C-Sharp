using System;

public class Program{
    public int[] IgnoreMiddleDigit(int[] input){
        int l = input.Length;
        int [] arr = null;
        if (l <= 0 || l > 20){
            arr = new int[0];
            return arr;
        }
        else{
            arr = new int[input.Length];
            for (int i = 0; i < input.Length; i++){
                int num = input[i];
                int j = 0;
                int reverse = 0;
                while(num != 0){
                    j++;
                    int rem = num % 10;
                    if (j != 2){
                        reverse = reverse * 10 + rem;
                    }
                    num = num / 10;
                }
                arr[i] = reverse;
            }
            return arr;
        }
    }

    public static void Main(){
        Console.WriteLine("Enter the array size");
        int size = Convert.ToInt32(Console.ReadLine());
        int [] arr = new int[size];
        Program program = new Program();
        if (size <= 0 || size > 20){
            arr = program.IgnoreMiddleDigit(arr);
            Console.WriteLine("Invalid array size");
        }
        else{
            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < arr.Length; i++){
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            arr = program.IgnoreMiddleDigit(arr);
            for (int i = 0; i <arr.Length; i++){
                Console.WriteLine("{0}", arr[i]);
            }
        }
        
    }
}