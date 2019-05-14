using System;

namespace Program{
    class SumOfNumber
    {
        int sum=0;
        //Read number
        public void readNumbers()
        {
 Console.WriteLine("Enter 10 numbers");
            for( int i=0;i<10;i++)
            {
            Console.WriteLine("Number"+(i+1));
           int num=Convert.ToInt32(Console.ReadLine());
           //sum of digits in the number
            sum=sum+num;

            }
           Console.WriteLine("Output"+sum);
           

        }

        
    }
}