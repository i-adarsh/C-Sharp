using System;

public class Program{
    public double FindAverageAge(int[] age){
        double sum = 0;
        for (int i = 0; i < age.Length; i++){
            sum += age[i];
        }
        sum = sum/age.Length;
        if (sum <= 28 || sum >= 40){
            return 0;
        }
        else{
            return sum;
        }
    }

    public static void Main(){
        Program program = new Program();
        Console.WriteLine("Enter total no.of employees:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number >= 2){
            int [] age = new int[number];
            Console.WriteLine("Enter the age for {0} employees:");
            for (int i = 0; i < age.Length; i++){
                age[i] = Convert.ToInt32(Console.ReadLine());
            }
            double average = program.FindAverageAge(age);
            if (average == 0){
                Console.WriteLine("0");
            }
            else{
                Console.WriteLine("The average age is {0}", average);
            }
            
        }
        else{
            Console.WriteLine("Please enter a valid employee count");
        }
    }

}