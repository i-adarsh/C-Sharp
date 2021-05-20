using System;

public class CalculatorProgram{
    public int Addition (int a, int b){
        return (a + b);
    }
    public int Subtraction (int a, int b){
        return (a - b);
    }
    public int Multiplication (int a, int b){
        return (a * b);
    }
    public double Division (int a, int b, out double remainder){
        remainder = a % b;
        return (a / b);
    }
}

public class Program{
    public static void Main(){
        Console.WriteLine("Enter the operator");
        char choice = Console.ReadLine()[0];
        Console.WriteLine("Enter the operands");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        CalculatorProgram calculate = new CalculatorProgram();
        if (choice == '+'){
            Console.WriteLine("Result of {0} {1} {2} is {3}", a, choice, b, calculate.Addition(a,b));
        }
        else if (choice == '*'){
            Console.WriteLine("Result of {0} {1} {2} is {3}", a, choice, b, calculate.Multiplication(a,b));
        }
        else if (choice == '-'){
            Console.WriteLine("Result of {0} {1} {2} is {3}", a, choice, b, calculate.Subtraction(a,b));
        }
        else if (choice == '/'){
            Console.WriteLine("Result of {0} {1} {2} is {3}", a, choice, b, calculate.Division(a,b, out double remainder));
            Console.WriteLine($"Remainder ={remainder}");
        }
        else{
            Console.WriteLine("Invalid Operator");
        }
    }
}