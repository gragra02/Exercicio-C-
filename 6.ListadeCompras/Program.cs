using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> lista = new List<string>();
        Console.WriteLine("Digite os itens da lista (digite 'sair' para finalizar):");
        string item = "";

        while (item != "sair")
        {
            item = Console.ReadLine();
            if (item != "sair")
                lista.Add(item);
        }

        foreach (string i in lista)
        {
            Console.WriteLine(i);
        }
    }
}