using System;

namespace estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do primeiro bimestre da disciplina: ");
           
            int primNota = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo bimestre da disciplina: ");
            int seguNota = Int32.Parse(Console.ReadLine());
            int media = primNota * 2 + seguNota * 3; 
            Console.WriteLine("media: " + media/5);
        }
    }
}
