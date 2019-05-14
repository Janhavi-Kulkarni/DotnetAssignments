using System;
using Program;
namespace MainNamespace
{
  class MainClass
  {
      public static void Main(String[] args)
      {
        Console.WriteLine("1)Find sum of number");
        SumOfNumber num=new SumOfNumber();
         num.readNumbers();

Console.WriteLine("\n \n 2)Find Day on Number");
        DaysOfWeek dw=new DaysOfWeek();
         dw.DayIf();
         dw.DaySwitch();
         Console.ReadLine();

Console.WriteLine("\n \n 3)Pattern Printing");
        PatternPrint PP=new PatternPrint();
         PP.print();

        Console.WriteLine("\n \n 4)Find Febonacci Series");

        Fibonacci fb=new Fibonacci();
         fb.printFibonacci();

         Console.WriteLine("\n \n 5)Convert 2D array to 1D array");

        ArrayOperations arrayopr=new ArrayOperations();
         arrayopr.invokeArrayMethod();

  Console.WriteLine("\n \n 6)Provide input and check whether it is present in array or not");
         ElementInString ele=new ElementInString();
         ele.findElement();

          Console.WriteLine("7)Reverse Array");

         ReverseArray rev=new ReverseArray();
         rev.acceptElement();

          Console.WriteLine("\n \n 8)Find maximum and minumum number in array");

         MinMax mm=new MinMax();
         mm.invokeMethods();

          Console.WriteLine("\n \n 9)Enter string and perform trim,split and join operations");

         TrimString trims=new TrimString();
         trims.trimString();
         trims.splitAndJoin();

          Console.WriteLine("\n \n 10)Remove spaces and special symbols from string");

        EscapeSpecialSymbol escSym=new EscapeSpecialSymbol();
         escSym.replaceSym();

 Console.WriteLine("\n \n 11)Reverse String ");
         RevString rs=new RevString();
         rs.loopReverse();
         rs.builtInReverse();

 Console.WriteLine("\n \n 12)Merge string as well as merge non duplicates");
 mergeStrings mstr=new mergeStrings();
 mstr.mergeString();
 mstr.InsertString();


         

         
      }
  }
    
}