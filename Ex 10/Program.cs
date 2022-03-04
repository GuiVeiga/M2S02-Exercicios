Console.Write("Entre com o salário do colaborador: ");
var salario = float.Parse(Console.ReadLine());

if (salario <= 280)
{
    var salarioPorcentagem = (salario * 20) / 100;
    var salarioReajustado = salario + salarioPorcentagem;

    Console.WriteLine("\n---------- Salário ----------");
    Console.WriteLine($"Salário antes do reajuste: {salario}");
    Console.WriteLine("Percentual de aumento: 20%");
    Console.WriteLine($"Valor do aumento: {salarioPorcentagem}");
    Console.WriteLine($"Salário após reajuste: {salarioReajustado}");
}

else if (salario > 280 && salario <= 700)
{
    var salarioPorcentagem = (salario * 15) / 100;
    var salarioReajustado = salario + salarioPorcentagem;

    Console.WriteLine("\n---------- Salário ----------");
    Console.WriteLine($"Salário antes do reajuste: {salario}");
    Console.WriteLine("Percentual de aumento: 15%");
    Console.WriteLine($"Valor do aumento: {salarioPorcentagem}");
    Console.WriteLine($"Salário após reajuste: {salarioReajustado}");
}

else if (salario > 700 && salario <= 1500)
{
    var salarioPorcentagem = (salario * 10) / 100;
    var salarioReajustado = salario + salarioPorcentagem;

    Console.WriteLine("\n---------- Salário ----------");
    Console.WriteLine($"Salário antes do reajuste: {salario}");
    Console.WriteLine("Percentual de aumento: 10%");
    Console.WriteLine($"Valor do aumento: {salarioPorcentagem}");
    Console.WriteLine($"Salário após reajuste: {salarioReajustado}");
}

else
{
    var salarioPorcentagem = (salario * 5) / 100;
    var salarioReajustado = salario + salarioPorcentagem;

    Console.WriteLine("\n---------- Salário ----------");
    Console.WriteLine($"Salário antes do reajuste: {salario}");
    Console.WriteLine("Percentual de aumento: 5%");
    Console.WriteLine($"Valor do aumento: {salarioPorcentagem}");
    Console.WriteLine($"Salário após reajuste: {salarioReajustado}");
}