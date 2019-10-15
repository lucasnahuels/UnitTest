using System;

namespace ConsoleApp2
{
    class Program
    {
        //Given a year, report if it is a leap year.
        //The tricky thing here is that a leap year in the Gregorian calendar occurs:
        //on every year that is evenly divisible by 4
        //except every year that is evenly divisible by 100
        //unless the year is also evenly divisible by 400
        //For example, 1997 is not a leap year, but 1996 is. 1900 is not a leap year, but 2000 is
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a year to check whether it is leap or it isn´t");
            string yearAsked = Console.ReadLine();

            //first shot
            //if (int.Parse(yearAsked) % 4 == 0)
            //{
            //    if (int.Parse(yearAsked) % 100 == 0 && int.Parse(yearAsked) % 400 != 0)
            //    {
            //        Console.WriteLine("The year is not leap");
            //        return;
            //    }
            //    Console.WriteLine("The year is leap");
            //}
            //-----------------------------------------------------------------
            //second shot
            bool IsLeapYearSecondShot(int year)
            {
                if (int.Parse(yearAsked) % 4 != 0 ||
                    int.Parse(yearAsked) % 4 == 0 && int.Parse(yearAsked) % 100 == 0 && int.Parse(yearAsked) % 400 != 0)
                {
                    return false;
                }

                return true;
            }


            //third shot
            bool IsLeapYearThirdShot(int year)
            {
                return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
            }


            //recordar hacer unit test
        }
    }
}
