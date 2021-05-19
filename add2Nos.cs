using System;

namespace Test{

  public class Sum{
    public static void Main(){
      Console.Write("Enter 1st Number : ");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter 2nd Number : ");
      int b = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Sum of {0} and {1} is {2}", a, b, (a + b));
    }
  }

}
