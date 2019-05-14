using System;

namespace Program
{
    
    class ReverseArray
    {
        int elementCount;
        char temp;

//Accept input from user and reverse array
    public void acceptElement()
    {
        //Accept input from user
        Console.WriteLine("Enter number of elements which you want to add in array");
        int elementCount=Convert.ToInt32(Console.ReadLine());
      char[] cArray =new Char[elementCount];
     // char[] revArray=new char[elementCount];

      Console.WriteLine("Enter 'character' elements you want to enter in array");
      for(int i=0;i<elementCount;i++)
      {
          cArray[i]=Convert.ToChar(Console.ReadLine());
      }
     int endLength=cArray.Length-1;
     //Reverse array
    for (int i=0;i<endLength-1;i++,endLength--)
    {
       
          temp=cArray[i];
          cArray[i]=cArray[endLength];
          cArray[endLength]=temp;



    
    }
    
    Console.WriteLine(cArray);

    }
   



    }
}