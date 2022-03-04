Console.WriteLine("Este programa realiza a conversão de graus Celsius em Fahrenheit. \n");

Console.Write("Entre com a temperatura em graus Celsius: ");
var celsius = Console.ReadLine();

var fahrenheit = (1.8 * Convert.ToInt32(celsius)) + 32;

Console.WriteLine(String.Format("Temperatura em Celsius: {0:0}", celsius));
Console.WriteLine(String.Format("Temperatura em Fahrenheit: {0:0}", fahrenheit));