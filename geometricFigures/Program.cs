using Figures;
using System;

namespace geometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagingFigures.CreateFigures();
            ManagingFigures.CalculationArea();
            
            Console.WriteLine(" "); 
            ManagingFigures.CalculationPerimeter();
           
            Console.WriteLine(" ");
            ManagingFigures.SearchMaxArea();
            
            Console.WriteLine(" ");
            ManagingFigures.SearchMaxPerimeter();

            Console.ReadKey();
            
        }
    }
}
