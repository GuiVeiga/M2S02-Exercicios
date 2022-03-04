using Ex_8;
using Newtonsoft.Json;

var notas = ReadJson();
if (notas != null)
{
    foreach (var nota in notas)
    {
        var media = (nota.Nota1 + nota.Nota2 + nota.Nota3) / 3;
        if (media < 5)
        {
            var reprovadosToJson = JsonConvert.SerializeObject(nota);
            File.WriteAllText(@"C:\Users\guilh\Documents\C# .NET\M2S02\Ex 9\reprovados.json", reprovadosToJson);
            Console.WriteLine(reprovadosToJson);
        }
    }
}

static List<Notas> ReadJson()
{
    string fileName = @"C:\Users\guilh\Documents\C# .NET\M2S02\Ex 8\notas.json";

    if (File.Exists(fileName))
    {
        var notas = JsonConvert.DeserializeObject<List<Notas>>(File.ReadAllText(fileName));

        return notas;
    }

    return null;
}