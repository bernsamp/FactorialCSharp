    using System;

      public class Factorial{

         public static void Main(string[] args){  

           int factorial = 1;

           Console.Write("Enter a number: ");      
           int number= int.Parse(Console.ReadLine());

           for(int i=1; i<=number; i++){      
            factorial *= i;      
           }      
           Console.Write("Factorial of " + number + " is: " + factorial);    
         }  
      }  