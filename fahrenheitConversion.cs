using System;
class Program {
    public int celsius;
    
    public double FahrenheitConversion (int celsius){
        double fahrenheit;      
        fahrenheit = ((Convert.ToDouble(celsius) * 9) / 5 ) + 32;
        return fahrenheit;
    }
    public static void Main(string[] args){
        Console.WriteLine("Enter the celsius value");
        Program obj = new Program();
        obj.celsius = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(obj.FahrenheitConversion(obj.celsius));
    }
}