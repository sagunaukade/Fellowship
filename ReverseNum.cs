using System;
namespace MyFirstApp
{
    class ReverseNum
    {
        public static void FindReverseNum()
        {
            Console.WriteLine("Enter the reverse number");
            int number=Convert.ToInt32(Console.ReadLine());
            int reminder , reverse=0;
            while(number>0)
            {
                reminder=number%10;
                reverse=(reverse*10)+reminder;
                number=number/10;
                
            }
            Console.WriteLine("After Reverse" +reverse);
        }
    }
}
