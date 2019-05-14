using System;

class mergeStrings
{
    string str1,str2;

//Merge two strings
    public void mergeString()
    {
        //Accept strings from user
        Console.WriteLine("Enter first string");
        str1=Console.ReadLine();
       
        Console.WriteLine("Enter second string");
        str2=Console.ReadLine();

//Merge Second String to First String
       String MergetoFirst=String.Concat(str1,str2);
       
//Merge First string to second String
       String MergetoSecond=String.Concat(str2,str1);

//Print merged strings
     Console.WriteLine("Output for merging second string to first string is="+MergetoFirst);
     Console.WriteLine("Output for merging first string to second string is="+MergetoSecond);
       

       
    }
    //Function to insert one string to other by avoiding duplicate characters
    public void InsertString()
{
    //Accept input strings fro  user
    Console.WriteLine("Enter first string");
        str1=Console.ReadLine();

        Console.WriteLine("Enter second string");
        str2=Console.ReadLine();

        //Converst strings to character array
char[] ch1 = str1.ToCharArray();
char[] ch2 = str2.ToCharArray();

//Traverse string and insert
for(int i=0; i<str1.Length; i++)
{
for(int j=0; j<str2.Length; j++)
{
if (ch2[j] == ch1[i])
ch2[j] = ' ';
}
}

str2 = new String(ch2);

//Split,trimand join to avoid spaces
char[] splitchar = { ' ' };
String[] substr = str2.Split(splitchar);

for(int i=0; i<substr.Length; i++)
{
substr[i] = substr[i].Trim();
}

str2 = string.Join("", substr);
//Insert string

str1 = str1.Insert(1, str2);

//Print output
Console.WriteLine("The new non-duplicate merged string is : {0}", str1);
}
}
