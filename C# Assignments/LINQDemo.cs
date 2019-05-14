using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Program
{
    class LinqDemo
    {
       // int number;
         public void findSecondMax()
         {
             
             List<int> numlist=new List<int>();
             numlist.Add(3);
             numlist.Add(4);
             numlist.Add(1);
             numlist.Add(5);
             numlist.Add(8);

             
                            //var firstMax = (from num in numlist select num).Max();
                          //  Console.WriteLine(firstMax);

                            // var secondMax=(from num in numlist where num.IsNotIn(firstMax) select num).Max();
                            // var secondMax=(from num in numlist where firstMax.IsNotIn(numlist) select num).Max();
                            //var secondMax=(from num in numlist where firstMa select num).Max();
                           
                           
                   //  var secondMax=(from num in numlist where !numlist.Contains(firstMax)select num).Max();
                          //var firstMax=(from num in numlist where !numlist.Contains((from num1 in numlist select num1).Max())select num).Max();
                        // var firstMax = from num in numlist where num NOT((from num1 in numlist select num).Max())select num.Max();

                        var FirstMax = numlist.Max();
                          List<int> numListShort = numlist.Where(number => number != FirstMax).ToList();
                            var SecondMax = (from number in numListShort                                    
                                    select number).Max();
                          Console.WriteLine("Second Maximum Number Is"+SecondMax);

         }     

    }
}