using System;

namespace Classes
{
    public class WordCount
    {
        String Input="This is test string";
       int Wordcount=0;
       int Elementcount;
       public void CountWord()
       {
          
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
