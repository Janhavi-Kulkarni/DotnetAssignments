using NUnit.Framework;
using Classes;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        

        [Test]
        public void Program1()
        {
           Console.WriteLine("1. Count the no of words in a string");
            WordCount count=new WordCount();
            count.CountWord();
        }

        [Test]
        public void Program2()
        {
           Console.WriteLine("2. Convert String to Title and Camel Test");
            StringConversion convert=new StringConversion();
            convert.ToCamel();
            convert.ToTitle();
        }

        [Test]
        public void Program3()
        {
           Console.WriteLine("3. Count the distinct words in a string");
           DistinctWord word=new DistinctWord();
           word.FindDistinctWord();
        }

        [Test]
        public void Program4()
        {
          Calculator calci=new Calculator();
           Console.WriteLine("Enter numbers");
           int num1=10;
           int num2=5;
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
        }

        [Test]
        public void Program5()
        {
           IntersetRate IR=new IntersetRate();
           int principal=50000;
           int tenure=3;
          decimal rate=2;
           IR.CalculateInterest(principal,tenure,rate);
        }

        [Test]
        public void Program6()
        {
           Console.WriteLine("5. LINQ to find second max");
           LinqDemo LQ=new LinqDemo();
           LQ.findSecondMax();
        }

    }
}