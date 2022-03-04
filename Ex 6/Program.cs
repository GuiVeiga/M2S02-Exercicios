Console.WriteLine("Este programa informa, através dos lados inseridos, se a figura é um triangulo e o seu tipo \n");

Console.Write("Entre com o lado a: ");
var a = Convert.ToInt32(Console.ReadLine());
Console.Write("Entre com o lado b: ");
var b = Convert.ToInt32(Console.ReadLine());
Console.Write("Entre com o lado c: ");
var c = Convert.ToInt32(Console.ReadLine());

if (a + b > c || a + c > b || b + c > a)
{
    Console.WriteLine("É um triangulo!");

    if (a == b && a == c && b == c)
    {
        Console.WriteLine("Tipo de triângulo: Equilátero");
    }
    else if (a == b || a == c || b == c)
    {
        Console.WriteLine("Tipo de triângulo: Isósceles");
    }
    else
    {
        Console.WriteLine("Tipo de triângulo: Escaleno");
    }
}