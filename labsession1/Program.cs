using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length of the rectangle:");
            double length = double.Parse(Console.ReadLine());

            Console.Write("enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());

            double area = (length * width);
            Console.WriteLine("th area of rectangle is:" + area);
            Console.ReadLine();
        }
    }
}
