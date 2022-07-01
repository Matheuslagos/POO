
using System;
namespace estudos
{
    class MainClass
    {
 
        public static double AreaTriang(double b, double h)
        {
            double area ;
            area = b * h / 2;
            return area;
        }
        static void Main(string[] args)
        {
            double x = AreaTriang(10, 20);
            Console.WriteLine(x);
            double y = AreaTriang(10, 10);
            Console.WriteLine(y);
        }
    }
  
}
