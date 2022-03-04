Console.WriteLine("Este programa mostra o menor número entre 7 números diferentes. \n");

List<double> listaNumeros = new List<double>();

for (int i = 1; i <= 7; i++)
{
    Console.Write($"Entre com o {i}º número: ");
    var numero = Console.ReadLine();
    listaNumeros.Add(double.Parse(numero));
}

Console.WriteLine($"\nO maior número é: {listaNumeros.Min()}");