using System;  
  public class Factorial 
   {  
	 public static void Main(string[] args)  
	  {  
	   int i,fact=1,number;      
	   Console.Write("Enter any Number: ");
        number = Convert.ToInt32(Console.WriteLine());

        for(i=1;i<=number;i++){      
		fact=fact*i;      
	   }      
	   Console.Write("Factorial of " +number+" is: "+fact);    
	 }  
  }  