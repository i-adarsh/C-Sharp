using System;

public class Program{
    public static String Validate (int side1, int side2, int side3){
        if (side1 <= 0 && side2 <= 0 && side3 <= 0){
            return "Invalid Input";
        }
        else{
            return "Valid";
        }
    }
    public static void Main(){
        Console.WriteLine("Enter the value for side1");
        int side1  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value for side2");
        int side2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value for side3");
        int side3  = Convert.ToInt32(Console.ReadLine());
        String valid = Validate(side1, side2, side3);
        if (valid == "Valid"){
            if ((side1 + side2) > side3){
                Console.WriteLine("Sides form a Triangle");
            }
            else if((side1 + side3) > side2){
                Console.WriteLine("Sides form a Triangle");
            }
            else if((side2 + side3) > side1){
                Console.WriteLine("Sides form a Triangle");
            }
            else{
                Console.WriteLine("Sides does not form a Triangle");
            }
        }
        else{
            Console.WriteLine(valid);
        }
    }
}