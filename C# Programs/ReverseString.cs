using System;

namespace Program
{
  class RevString
  {
      String str;
      String revString="";
      String temp;
      //Reverse string using loop
      public void loopReverse()
      {
        //Accept input from user
        Console.WriteLine("Enter string");
        str=Console.ReadLine();
        //Find length of string
         int stringLength=str.Length-1;
         
//Reverse string
         while(stringLength>=0)
         {
              revString=revString+str[stringLength];
              stringLength--;
         }

         Console.WriteLine("Reversed String is: "+revString);

      }

//Reverse string using built in function
      public void builtInReverse()
      {
        //Accept string from user
        Console.WriteLine("Enter string");
        str=Console.ReadLine();
         
         //Convertt string to character array
         char[] strtoArr=str.ToCharArray();

         //Reverse using built in function
         Array.Reverse(strtoArr);
         Console.WriteLine(strtoArr);
      }
  }

}