using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchBoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter a number");
            int wrongyBoi;
            try{
                wrongyBoi = Convert.ToInt32(Console.ReadLine());

            }
            catch()
            {

            }
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter a number");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter a number");
            double num4 = Convert.ToDouble(Console.ReadLine());
            double total = num1 + num2 + num3 + num4;
            Console.WriteLine("Total is: " + total);
            
                
        }
    }
}
