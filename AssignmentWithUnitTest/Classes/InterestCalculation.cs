using System;

namespace Classes
{
    interface IData
  {
         void CalculateInterest(int principal,int tenure,decimal rate);
  }

 public class IntersetRate : IData
  {
       

 

       public void CalculateInterest(int principal,int tenure,decimal rate)
       {
           int Interest=Convert.ToInt32(principal*(1+rate*tenure));
           Console.WriteLine("Interest Rate="+Interest);

       }
  }
}