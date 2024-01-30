using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; 
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("\nEnter a number:");
            }
            
           
             Console.WriteLine("enter a number:");
             number= int.Parse(Console.ReadLine());
             if (number %2== 0)
             {
               Console.WriteLine("it's Even ");
                    
             }
                
            else
            {
                    Console.WriteLine( "is odd");
                 
            }
            
        }
    }
}
