using System;
using System.Text.RegularExpressions;

namespace Program
{
    class DistinctWord
    {

         String Input;
         int Arraylength;
         int WordCount=0;
        public void FindDistinctWord()
        {
            Console.WriteLine("Enter String");
            Input=Console.ReadLine();

            String[] SplittedString=Input.Split(' ');
            Arraylength=SplittedString.Length;
            Console.WriteLine(Arraylength);

            for(int i=0;i<Arraylength-1;i++)
            {
               
                for(int j=i;j<Arraylength-1;j++)
                {
                    if(i!=j)
                    {
                    if((SplittedString[i].Equals(SplittedString[j])))
                    {
                       WordCount++;
                    }
                    }
                }
            }   
            int DistinctWord=Arraylength-WordCount;

            Console.WriteLine("Distinct Word Count="+DistinctWord);
        }
    }
}