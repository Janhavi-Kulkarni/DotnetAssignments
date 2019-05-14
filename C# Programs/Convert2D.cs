using System;

namespace Program
{
    class ArrayOperations
    {
        int row,columns;
     //take user input for 2D array
        public int[,] readArrayElements()
        {
          //2D array
          Console.WriteLine("Enter number of rows you want to insert in 2D array");
          row=Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Enter number of columns you want to insert in 2D array");
          columns=Convert.ToInt32(Console.ReadLine());

          int[,] TwoD=new int[row,columns];

          Console.WriteLine("Enter elements in matrix");
          for(int i=0;i<row;i++)
          {
              for(int j=0;j<columns;j++)
              {
                  
                  TwoD[i,j]=Convert.ToInt32(Console.ReadLine());
              }
          }
          return TwoD;
        }

//Print elemets of 2D array
        public void printArrayElements(int[,] TwoDim)
        {
            Console.WriteLine("2D Array Elements are:");
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<columns;j++)
                {
                     Console.Write(TwoDim[i,j]);
                     Console.Write("\t");
                }
            Console.Write("\n");
            }
            
        }

//Convert 2D array to 1D array
        public void convertTo1D(int[,] TwoDim)
        {
            int[] OneD=new int[row*columns];
            int k=0;
             
             for(int i=0;i<row;i++)
             {
                 for(int j=0;j<columns;j++)
                 {
                     OneD[k++]=TwoDim[i,j];

                 }
             }
             Console.WriteLine("One Dimensional array is:");
             for (int i=0;i<row*columns;i++)
             {
                 Console.Write("\t");
                 Console.WriteLine(OneD[i]);
                 
             }


            
        }

// Invoke methods for 2D and 1D array
        public void invokeArrayMethod()
        {
         ArrayOperations arrayopr=new ArrayOperations();
         int [,] TwoDim=arrayopr.readArrayElements();
         arrayopr.printArrayElements(TwoDim);
         arrayopr.convertTo1D(TwoDim);

        }
    }
}