using static System.Console;

WriteLine("digite o nome do Arquivo:");
var nome = ReadLine();

nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

WriteLine("Digite Enter para Finalizar");
ReadLine();

static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
}
static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Esta é a primeira linha");
        sw.WriteLine("Esta é a segunda linha");
        sw.WriteLine("Esta é a terceira linha");
    }
    catch
    {
        WriteLine("O nome do arquivo é inválido.");
    }


}

