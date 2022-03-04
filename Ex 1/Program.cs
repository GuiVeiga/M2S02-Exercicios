Console.WriteLine("Este programa calcula a área de um círculo \n");

Console.Write("Entre com o raio de um círculo: ");
var r = Console.ReadLine();

var area = Math.PI * Math.Pow(float.Parse(r), 2);

Console.WriteLine(String.Format("Valor de PI: {0:0.00}", Math.PI));
Console.WriteLine($"Valor do raio ao quadrado: {Math.Pow(float.Parse(r), 2)}");
Console.WriteLine("Valor da area do círculo: {0:0.00}", area);