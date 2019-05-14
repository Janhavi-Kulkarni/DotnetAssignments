using System;

namespace Program
{
    class MinMax
    {
        int arrayLimit;
        
//Accept input from user and store it in array
        public int[] arrayElement()
        {
             Console.WriteLine("Enter size of array");
             arrayLimit=Convert.ToInt32(Console.ReadLine());
             int[] IntArray=new int[arrayLimit] ;

              Console.WriteLine("Enter Numbers in array");
              for(int i=0;i<arrayLimit;i++)
              {
                  IntArray[i]=Convert.ToInt32(Console.ReadLine());
              }
        return IntArray;
        }

//find maximum element
        public void findMax(int[] orgArray)
        {
             int max=orgArray[0];
            for(int i=0;i<arrayLimit;i++)
            {
                if(orgArray[i]>max)
                {
                    max=orgArray[i];
                }
            }
            Console.WriteLine("Maximum Element is:");
            Console.WriteLine(max);
        }

//Find minimum element
        public void findMin(int[] orgArray)
        {
             int min=orgArray[0];
            for(int i=0;i<arrayLimit;i++)
            {
                if(orgArray[i]<min)
                {
                    min=orgArray[i];
                }
            }
            Console.WriteLine("Minimum Element is:");
            Console.WriteLine(min);
        }

//Invoke methods for reading array,finding maximum as well as minimum
        public void invokeMethods()
        {
            MinMax mm=new MinMax();
            int[] IArray=mm.arrayElement();
            mm.findMax(IArray);
            mm.findMin(IArray);
        }
    }
}