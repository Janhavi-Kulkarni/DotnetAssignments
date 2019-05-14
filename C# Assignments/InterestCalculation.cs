using System;

namespace Program
{
  interface IData
  {
         void CalculateInterest(int principal,int tenure,decimal rate);
  }

  class IntersetRate : IData
  {
       int principal;
       int tenure;
       Decimal rate;

 

       public void CalculateInterest(int principal,int tenure,decimal rate)
       {
           int Interest=Convert.ToInt32(principal*(1+rate*tenure));
           Console.WriteLine("Interest Rate="+Interest);

       }
  }

  

}