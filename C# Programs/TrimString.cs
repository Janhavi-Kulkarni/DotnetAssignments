using System;

namespace Program
{
    class TrimString
    {
        String str;

//Left trim and right trim blank space
        public void trimString()
        {
//Accept input from user
            Console.WriteLine("Enter String with blank space at left/right");
            str=Console.ReadLine();

//Trim from start if string contain blank space at start
            if(str.Contains(" "+str))
            {
                str=str.TrimStart();
               
                
            }
            //Trim from end if string contain blank space at end
           else if(str.Contains(str+" " ))
            {
                str=str.TrimEnd();
               
                
            }
           //Print string
           Console.WriteLine(str);

        }
//split,trim and join string
        public void splitAndJoin()
        {
            //Accept input from user 
            Console.WriteLine("Enter long String with spaces to split");
            str=Console.ReadLine();
//Split string 
            String[] splittedString=str.Split(' ');
            string restString=splittedString[1];

            //Console.WriteLine(splittedString);

            //Print rest of string after splitting
            Console.WriteLine("First element of rest of string after splitting="+restString);
//Trim spaces in rest of string and print
            Console.WriteLine("Trimmed String="+restString.Trim());

//Join plitted string and print
            string joinedText=string.Join(' ',splittedString);
            Console.WriteLine("Joined String="+joinedText);
        }
    }
}