using System;
namespace estudos
{
    
    class MainClass
    {
    
        static void Main(string[] args)
        {
            Circulo x = new Circulo();            
                x.raio = 10;
                x.pi = 3.14;
            
            Console.WriteLine($"area:{x.CalcArea()}");
            Circulo y = new Circulo();
                y.raio = 10;
                y.pi = 3.14;
       
            Console.WriteLine(x.CalcPerim());
        }
        class Circulo
        {
            public double  raio, pi;
            public double CalcArea()
            {
                double area = pi * raio;
                return area;
            }
            public double CalcPerim()
            {
                double perim = 2 * pi * raio;
                return perim;
            }
        }
    }
    
}
