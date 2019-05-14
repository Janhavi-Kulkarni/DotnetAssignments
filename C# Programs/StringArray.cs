using System;

namespace Program
{

    class ElementInString{


        String [] str=new String [5]{"Mon","Tue","Wed","Thu","Fri"};
        
//Find whether element is present in array 
        public void findElement()
        {
            //Accept input from user
            Console.WriteLine("Enter element you want to search within {Mon,Tue,Wed,Thu,Fri}");
            String searchVal= Console.ReadLine();
            int index=-1;
            //Search input in given array
            foreach(String s in str)
            
            {
                 index=Array.IndexOf(str,searchVal);
              //Compare input to values in array and print result
               if(searchVal==s)
               {
                
                  Console.WriteLine("Result=true");
                  
                //  index=s.IndexOf(searchVal);
                   Console.WriteLine("Found at below position:");
                  Console.WriteLine(index);
                   
                  break;
                  
                 
               }
             
               
               
               
                 
                  
               
            }
            if(index==-1)
            Console.WriteLine("false");
           
            

        
        }

        

    }
}