

using System;
using System.Collections.Generic; // chama um framework onde tem disponivel um metodo de listagem.

class Program
{
  class Aluno
  {
    public string nome;
    public double nota1;
    public double nota2;
    public double nota3;
    public double media;
  }

  static void Main(string[] args)
  {

    // declaracao de variaveis



    //aluno -> classe 
    //aluno1 -> var que vai guardar o objeto 
    //new Aluno() -> cria uma nova instancia (objeto) dentro da classe aluno 

    List<Aluno> listaAlunos = new List<Aluno>(); // cria lista da classe aluno 

    Console.Write("Cadastrar Novo Aluno? 1 - Sim / 0 Nao.");
    int cadastro = Convert.ToInt32(Console.ReadLine());
    if (cadastro == 1)
    {
      Console.Write("Quantos alunos voce deseja cadastrar?");
      int quantidade = Convert.ToInt32(Console.ReadLine());

      // define repeticao de laco

      for (int i = 0; i < quantidade; i++)
      {
        Aluno aluno1 = new Aluno(); // declara um novo objeto da classe aluno

        Console.WriteLine("Aluno: ");
        string nomealuno = Console.ReadLine();
        aluno1.nome = nomealuno;

        Console.WriteLine("Nota 1° Trimestre: ");
        double notaprimeirotrismestre = Convert.ToDouble(Console.ReadLine());
        aluno1.nota1 = notaprimeirotrismestre;


        Console.WriteLine("Nota 2° Trimestre: ");
        double notasegundotrismestre = Convert.ToDouble(Console.ReadLine());
        aluno1.nota2 = notasegundotrismestre;

        Console.WriteLine("Nota 3° Trimestre: ");
        double notaterceirotrimestre = Convert.ToDouble(Console.ReadLine());
        aluno1.nota3 = notaterceirotrimestre;


        listaAlunos.Add(aluno1); // adiciona o objeto criado (NOVO ALUNO) dentro da lista

      }
      foreach (var aluno in listaAlunos)
      {
        aluno.media = (aluno.nota1 + aluno.nota2 + aluno.nota3) / 3;
        Console.WriteLine($"Aluno: {aluno.nome} - Média: {aluno.media}");
      }

    }
    else
    {
      Environment.Exit(0);

    }



  }
}
