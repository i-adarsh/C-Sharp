
Use mcs to compile the file
Use mono to run the fill

For Eg:

vim helloBye.cs
mcs helloBye.cs 
mono helloBye.exe 


vim helloBye.cs
mcs helloBye.cs 
mono helloBye.exe

========================================================================================================

To Create DLL file use csc

====================================================

File 1: dllEx1.cs 

using System;

namespace UtilityMethod
{

  public class MathsUtility
  {

    public static long Multiply(long x, long y)
    {
      return (x * y);
    }

    public static long Add(long a, long b)
    {
      return (a + b);
    }
    
  }

}


csc /target:<output_file_type> /out:<name_of_output> <source_code_file>

For Eg:

csc /target:library /out:UtilityMethod.dll dllEx1.cs


====================================================

File 2: dllEx2.cs 

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

For Compiling Second File

csc /r:UtilityMethod.dll dllEx2.cs 


Or If you want to make another DLL fromsecond File then run the below command

csc /r:UtilityMethod.dll /t:library dllEx2.cs 

====================================================

OR 

====================================================

After Creating both the files run the below Commands

csc /target:library /out:UtilityMethod.dll dllEx1.cs

csc /r:UtilityMethod.dll dllEx2.cs 

mono dllEx2.exe 

=====================

Output: 

Enter 1st Number : 32
Enter 2nd Number : 67
Sum of 32 and 67 is 99
Product of 32 and 67 is 2144


=====================


