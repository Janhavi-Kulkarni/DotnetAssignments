using System;

namespace Classes
{
    public class StringConversion
    {
        String Input= "This is test string";
        public void ToCamel()
        {
           
            string[] splittedString=Input.Split(' ');

            for(int i=0;i<splittedString.Length;i++)
            {
                if(i==0)
                {
                    splittedString[i]=splittedString[i].ToLower();              
                }

                else
                {
                      char[] output=splittedString[i].ToCharArray();
                        for(int j=0;j<splittedString[i].Length;j++)
                        {
                            

                            if(j==0)
                            {
                                output[j]=char.ToUpper(output[j]);
                            }
                            else
                            {
                                output[j]=char.ToLower(output[j]);
                            }
                        
                            
                        }
                         splittedString[i]=new string(output);

                }
            }
             string camelString = string.Join("", splittedString);
             Console.WriteLine(camelString);
        } 

          public void ToTitle()
          {
            
             string[] splittedString=Input.Split(' ');

            for(int i=0;i<splittedString.Length;i++)
            {
            
                    char[] output=splittedString[i].ToCharArray();
                        for(int j=0;j<splittedString[i].Length;j++)
                        {
                            

                            if(j==0)
                            {
                                output[j]=char.ToUpper(output[j]);
                            }
                            else
                            {
                                output[j]=char.ToLower(output[j]);
                            }
                        
                            
                        }
                         splittedString[i]=new string(output);

                
            }
             string TitleString = string.Join("", splittedString);
             Console.WriteLine(TitleString);
          }

    }
}