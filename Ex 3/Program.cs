Console.WriteLine("Este programa mostra o maior número entre 5 números diferentes. \n");

List<double> listaNumeros = new List<double>();

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Entre com o {i}º número: ");
    var numero = Console.ReadLine();
    listaNumeros.Add(double.Parse(numero));
}

Console.WriteLine($"\nO maior número é: {listaNumeros.Max()}");