Console.WriteLine("Insira a taxa de juros:");
        int taxa = int.Parse(Console.ReadLine());


Console.WriteLine("Insira a quantidadede de meses:");
        int meses = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor do inicial:");
        decimal valorInicial = decimal.Parse(Console.ReadLine());
        decimal valorFinal = valorInicial * (1 + taxa * meses);

Console.WriteLine($"O valor final é: {valorFinal}");