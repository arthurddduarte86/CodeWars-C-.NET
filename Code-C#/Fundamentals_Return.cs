/* https://www.codewars.com/kata/55a5befdf16499bffb00007b/train/csharp




Make multiple functions that will return the sum, difference, modulus, product, quotient, and the exponent respectively.

Please use the following function names:

addition = Add

multiply = Multiply

division = Divide

modulus = Mod

exponential = Exponent

subtraction = Subt

Note: All funcitons can return int and all will recieve 2 integers.

Note: All math operations will be: a (operation) b */



// TRADITIONAL WAY TO SOLVE, USING TRADITIONAL NOTATION



using System;
public static class Kata
{
  public static int Add(int a, int b)
    {
       return a+b;
    }
  public static int Multiply(int a, int b)
  {
    return a*b;
  }
  public static int Divide(int a, int b)
  {
    return a/b;
  }
  public static int Mod(int a, int b)
  {
    return a%b;
  }
  public static int Exponent(int a, int b)
  {
    return (int)Math.Pow(a,b);
  }
  public static int Subt(int a, int b)
  {
    return a-b;
  }
 
}

// BETTER AND MORE CLEAN SOLUTION

using System;
public static class Kata
{
  public static int Add(int a, int b) => a+b;
  public static int Multiply(int a, int b) => a*b;
  public static int Divide(int a, int b) => a/b;
  public static int Mod(int a, int b) => a%b;
  public static int Exponent(int a, int b) => (int)Math.Pow(a, b);
  public static int Subt(int a, int b) => a-b;
  
}










