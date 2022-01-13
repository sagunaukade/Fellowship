using System;
namespace Fellowship
{
    class SwapTwoNumbers
    {
        public static void SwapNum()
        {
          int num1,num2,temp=0;
          Console.WriteLine("Enter First Num");
          num1=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter Sec Num");
          num2=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Before Swap Value num1={0},num2={1}", num1,num2);
          temp=num1;
          num1=num2;
          num2=temp;
          Console.WriteLine("After Swap Value num1={0}, num2={1}", num1,num2);

        }
    }

    }
