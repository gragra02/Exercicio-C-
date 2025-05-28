using System;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o número:");
        int numero = int.Parse(Console.ReadLine());

        int horas = numero / 60;
        int minutos = numero % 60;

        Console.WriteLine($"{numero} minutos equivalem a {horas} hora(s) e {minutos} minuto(s).");
    }
}