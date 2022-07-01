using System;
namespace estudos
{
    class Program
    {
        public static void Main()
        {
            ContaBancaria x = new ContaBancaria();
            x.nome = "matheus";
            x.numero = "1230";
            x.deposito(900);
            Console.WriteLine("conta de " + x.nome);
            Console.WriteLine(x.numero);
            Console.WriteLine("saldo apos deposito");
            Console.WriteLine(x.saldo);
            x.sacar(100);
            Console.WriteLine("saldo apos saque");
            Console.WriteLine(x.saldo);
        }


    }
    class ContaBancaria
    {
        public string numero, nome;
        public double saldo;
        public void deposito(double valor)
        {
            this.saldo += valor;
        }
        public void sacar(double valor)
        {
            this.saldo -= valor;
        }
    }
}
