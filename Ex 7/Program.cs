Console.WriteLine("Este programa reverte um numero inteiro inserido \n");

Console.Write("Entre com o número a ser revertido: ");
int numero = int.Parse(Console.ReadLine());
int revertido = 0;

while (numero > 0)
{
    int restante = numero % 10;
    revertido = (revertido * 10) + restante;
    numero = numero / 10;
}
Console.WriteLine($"Número revertido: {revertido}");