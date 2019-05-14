using System;
using System.Text.RegularExpressions;


namespace Program
{
    class EscapeSpecialSymbol
    {
        String str;
        //escape spacial symbols and spaces from string
        public void replaceSym()
        {
            Console.WriteLine("Enter String containing special symbols and blank spaces");
            str=Console.ReadLine();
           // var escape=@"([^0-9a-zA-Z,.])";
            String outputString=Regex.Replace(str,@"([^0-9a-zA-Z,.])+","");
            Console.WriteLine("Output="+outputString);
            
        }
    }
}