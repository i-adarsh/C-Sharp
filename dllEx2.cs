using System;
using UtilityMethod;

namespace LibTest{

  class Program{
    public static void Main (String[] args){
      Console.Write("Enter 1st Number : ");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter 2nd Number : ");
      int b = Convert.ToInt32(Console.ReadLine());
      long product = MathsUtility.Multiply(a, b);
      long sum = MathsUtility.Add(a, b);
      Console.WriteLine("Sum of {0} and {1} is {2}", a, b, sum);
      Console.WriteLine("Product of {0} and {1} is {2}", a, b, product);
    }
  }

}
