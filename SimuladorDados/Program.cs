// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite rolar para rolar o dado:");
Console.ReadLine(); 
Random geradordeNumero = new Random();
int resultado = geradordeNumero.Next(1, 7);
Console.WriteLine($"O número sorteado foi: {resultado}");
