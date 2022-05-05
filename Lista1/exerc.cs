using System; 

public class Program {

  public static void Main(string[] args) {
  Console.WriteLine ("Digite seu nome:");
  string nome = Console.ReadLine();
  string[] frase = nome.Split(' ');
  Console.WriteLine($"Bem vindo ao C# {frase[0]}");

  Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
  Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
  }
}
