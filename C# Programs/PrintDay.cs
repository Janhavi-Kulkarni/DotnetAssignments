using System;

namespace Program
{
    class DaysOfWeek
    {
     
     //Find day on selecte3d number using If
        public void DayIf()
        {
            
            Console.WriteLine("Number 1-7 contains day present at perticular number");
            for (int i=0;i<7;i++)
            {
                if(i==1)
                Console.WriteLine("Monday");
                else if(i==2)
                Console.WriteLine("Tuesday");
                 else if(i==3)
                Console.WriteLine("Wednesday");
                 else if(i==4)
                Console.WriteLine("Thursday");
                 else if(i==5)
                Console.WriteLine("Friday");
                 else if(i==6)
                Console.WriteLine("Saturday");
                 else if(i==7)
                Console.WriteLine("Sunday");
            }

            
        }

//Find day on selecte3d number using switch
        public void DaySwitch()
        {
            String option=null;
            Console.WriteLine("Enter your choice from D1 to D7");
            option=Console.ReadLine();
            switch(option)
            {
                case "D1": Console.WriteLine("Monday");
                break;
                case "D2": Console.WriteLine("Tuesday");
                break;
                case "D3": Console.WriteLine("Wednesday");
                break;
                case "D4": Console.WriteLine("Thursday");
                break;
                case "D5": Console.WriteLine("Friday");
                break;
                case "D6": Console.WriteLine("Saturday");
                break;
                case "D7": Console.WriteLine("Sunday");
                break;
                default: Console.WriteLine("Invalid option");
                break;
            }
        }
    }
}