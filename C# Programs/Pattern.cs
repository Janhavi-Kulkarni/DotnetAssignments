using System;

namespace Program
{
    class PatternPrint
    {
        public void print()
        {
            Console.WriteLine("Enter number of rows you want to print");
            int row=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=row;i++)
            {
               for(int j=1;j<=i;j++)
               {
                   Console.Write("*");
                    
               }
               Console.WriteLine();
            }

        }
    }
}