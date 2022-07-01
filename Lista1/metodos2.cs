using System;
namespace estudos
{
    class Area
    {
        public static double AreaTriang(double b, double h)
        {
            double area;
            area = b * h / 2;
            return area;
        }
    }
    class MainClass
    {
 
       
        static void Main(string[] args)
        {
            double x = Area.AreaTriang(10, 20);
            Console.WriteLine(x);
            double y = Area.AreaTriang(10, 10);
            Console.WriteLine(y);
        }
    }
  
}
