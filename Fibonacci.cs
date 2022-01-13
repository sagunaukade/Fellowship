using System;  
  public class Fibonacci
   {  
     public static void Main(string[] args)  
      {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
         Console.Write("please enter how many fibonacci numbers we have to generate");
         int number= Convert.ToInt32(Console.ReadLine());
         int first=0 , second=1;
         int result=0;
         result=first+second;
         Console.WriteLine("first:{0} second:{1} result:{2}", first, second, result);

         }    
      }  
