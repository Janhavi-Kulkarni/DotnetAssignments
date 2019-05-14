using System;

namespace Program
{
    class Fibonacci
    {
        int f1=0,f2=1,sum=0;
        public void printFibonacci()
            {
               Console.WriteLine("Enter the limit till which fibonacci is to be print");
               int limit=Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Output=");
               for (int i=0;i<limit;i++)
               {
                   sum=f1+f2;
                   Console.WriteLine(sum);
                   f1=f2;
                   f2=sum;
               }


            }
        
    }
}