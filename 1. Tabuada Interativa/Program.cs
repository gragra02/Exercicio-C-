using System;

static class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Insira um número entre 0 e 10:");
            int numero = int.Parse(Console.ReadLine());
            int i = 1;

        while (i <= 10)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
            i++;
        }
    }
}