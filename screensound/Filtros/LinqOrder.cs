using screensound.Modelos;
namespace screensound.Filtros;

internal class LinqOrder
{
    //ordenando artistas em ordem alfabética e exibindo a lista
    public static void ExibirListaDeArtistas(List<Musica> musicas)
    {
        var artistasOrdenados = musicas
            .OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine("LISTA DE ARTISTAS ORDENADOS");
        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"- { artista}");
        }
    }
}
