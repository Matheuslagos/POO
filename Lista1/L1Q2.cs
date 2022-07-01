using System;

namespace estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu nome: ");
            string nome = Console.ReadLine();
            string[] nomeSeparado = nome.Split(' ');
            Console.WriteLine("Bem vindo ao c#," + nomeSeparado[0]);
        }
    }
}
