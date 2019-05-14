using System;

namespace Classes
{
   public class DistinctWord
    {

         String Input="This is test string.Count distinct words in test string";
         int Arraylength;
         int WordCount=0;
        public void FindDistinctWord()
        {
            
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
