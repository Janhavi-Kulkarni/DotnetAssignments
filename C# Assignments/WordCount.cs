using System;

namespace Program
{
   class WordCount
   {
       String Input;
       int Wordcount=0;
       int Elementcount;
       public void CountWord()
       {
           Console.WriteLine("Enter String");
           Input=Console.ReadLine();

           Char[] word=Input.ToCharArray();
           Elementcount=word.Length;

           for(int i=1;i<Elementcount;i++)
           {
               if(word[i]==' '||word[i]=='\n'||word[i]=='\t')
               {
                   Wordcount++;
               }
           }
           Console.WriteLine("Total Number of Words="+(Wordcount+1));

    


       }
   }

}