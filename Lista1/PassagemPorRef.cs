using System;
namespace estudos
{
    
    class MainClass
    {
        public static void Ordenar(ref int x, ref int y, ref int z)
        { int aux = 0;
            if(x > y)
            {
                aux = x;
                x = y;
                y = aux;
            }
            if (x > z)
            {
                aux = x;
                x = z;
                z = aux;
            }
            if (y > z)
            {
                aux = y;
                y = z;
                z = aux;
            }
            return;
        }
        static void Main(string[] args)
        {
            int a = 60, b = 20, c = 80;
            Ordenar(ref a, ref b, ref c);
            Console.WriteLine($"{a} {b} {c}");
        }
    }
  
}
