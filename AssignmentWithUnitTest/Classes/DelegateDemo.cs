using System;

namespace Classes
{
     public delegate void Addition(int num1,int num2);
  public delegate void Substraction(int num1,int num2);

  public delegate void Multiplication(int num1,int num2);

  public delegate void Division(int num1,int num2);

  public delegate void Modular(int num1,int num2);

public class Calculator
  {
        int Result;
      public void Sum(int a,int b)
      {
        Result=a+b;
        Console.WriteLine("Addition="+Result);
      }

      public void Substarct(int a,int b)
      {
        Result=a-b;
        Console.WriteLine("Substraction="+Result);
      }

      public void Multiply(int a,int b)
      {
        Result=a*b;
        Console.WriteLine("Multiplication="+Result);
      }

      public void Divide(int a,int b)
      {
        Result=a/b;
        Console.WriteLine("Division="+Result);
      }

      public void Mod(int a,int b)
      {
        Result=a%b;
        Console.WriteLine("Modular="+Result);
      }
  }

}