Console.WriteLine("Este programa mostra a ordem Decrescente de 10 números. \n");

List<double> listaNumeros = new List<double>();

for (int i = 1; i <= 10; i++)
{
    Console.Write($"Entre com o {i}º número: ");
    var numero = Console.ReadLine();
    listaNumeros.Add(double.Parse(numero));
}

var listaDecrescente = listaNumeros.OrderByDescending(numeros => numeros);

Console.WriteLine($"\nOrdem Decrescente:");

foreach (double numeros in listaDecrescente)
{
    Console.WriteLine(numeros);
}

