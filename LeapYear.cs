using System;
namespace Fellowship

{
    class LeapYear

    {
        //static void main(String[] args)

        //{
        public static void Main()
        {
            int year;
            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 400) == 0)
                Console.WriteLine("{0} is a leap year", year);
            else if ((chk_year % 100) == 0)
                Console.WriteLine("{0} is not a leap year", year);
            else if ((chk_year % 4) == 0)
                Console.WriteLine("{0} is a leap year", year);
            else
                Console.WriteLine("{0} is not a leap year", year);
        }
    }
}

