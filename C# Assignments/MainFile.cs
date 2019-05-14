using System;

namespace Program
{
    class MainClass
    {
        public static void Main(String[] arg)
        {
            Console.WriteLine("1. Count the no of words in a string");
            WordCount count=new WordCount();
            count.CountWord();
          
            
            Console.WriteLine("2. Convert String to Title and Camel Test");
            StringConversion convert=new StringConversion();
            convert.ToCamel();
            convert.ToTitle();
          
           Console.WriteLine("3. Count the distinct words in a string");
           DistinctWord word=new DistinctWord();
           word.FindDistinctWord();

           Console.WriteLine("4. Delegate Demo");

           Calculator calci=new Calculator();
           Console.WriteLine("Enter numbers");
           int num1=Convert.ToInt32(Console.ReadLine());
           int num2=Convert.ToInt32(Console.ReadLine());
           Addition AdditionObj=new Addition(calci.Sum);
           Substraction SubstarctionObj=new Substraction(calci.Substarct);
           Multiplication MultiplicationObj=new Multiplication(calci.Multiply);
           Division DivisionObj=new Division(calci.Divide);
           Modular ModularObj=new Modular(calci.Mod);

           AdditionObj(num1,num2);
           SubstarctionObj(num1,num2);
           MultiplicationObj(num1,num2);
           DivisionObj(num1,num2);
           ModularObj(num1,num2); 

            Console.WriteLine("4. OOPS Demo");

          IntersetRate IR=new IntersetRate();
            Console.WriteLine("Enter Principal amount");
           int principal=Convert.ToInt32(Console.ReadLine());
 
        
           Console.WriteLine("Enter Tenure");
           int tenure=Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Enter Interest Rate");
          decimal rate=Convert.ToDecimal(Console.ReadLine());
           IR.CalculateInterest(principal,tenure,rate);

          Console.WriteLine("5. LINQ to find second max");
           LinqDemo LQ=new LinqDemo();
           LQ.findSecondMax();


        }
    }
}
