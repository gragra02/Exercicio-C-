using System;

static class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Insira o seu ano de nascimento:");
        int anoNascimento = int.Parse(Console.ReadLine());
        int anoAtual = 2025;
        int idade = anoAtual - anoNascimento;
        Console.WriteLine($"Você tem {idade} anos.");
           
    }
}