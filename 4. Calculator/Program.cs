﻿using System;
using System.Threading.Tasks.Dataflow;

namespace Calculator

{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");


            Console.WriteLine("----------------------");

            Console.WriteLine("Escolha uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;


            }
        }


        static void Soma()
        {
            Console.WriteLine("Primeiro valos: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine(v1);
     
        }
        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é:{resultado} ");

        }
        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é:{resultado} ");
        }
        static void Divisao()
        {
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é:{resultado} ");
        }
    }
}