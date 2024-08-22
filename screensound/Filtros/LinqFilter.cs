using screensound.Modelos;
namespace screensound.Filtros;

internal class LinqFilter
{
    //filtrando gêneros musicais
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine(genero);
        }
    }

    //filtrando artistas por gênero
    public static void FiltrarArtistaPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas
            .Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine($"ARTISTAS DO GÊNERO {genero}");
        foreach (var artista in artistasPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    //filtrando músicas por artista
    public static void FiltrarMusicasDoArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas
            .Where(musica => musica.Artista!.Equals(artista)).ToList();
        Console.WriteLine(artista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    //filtrando músicas por ano
    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasPorAno = musicas
            .Where(musica => musica.Ano.Equals(ano))
            .Select(musicas => musicas.Nome)
            .Distinct()
            .OrderBy(musica => musica)
            .ToList();
        foreach (var musica in musicasPorAno)
        {
            Console.WriteLine($"- {musica}" +
                $"ANO: {ano}");
        }
    }

    //filtrando músicas por tonalidade
    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidade) {
        var musicasPorTonalidade = musicas
            .Where(musica => musica.Tonalidade.Equals(tonalidade))
            .Select(musica => musica.Nome)
            .Distinct()
            .ToList();

        Console.WriteLine($"MÚSICAS DE TONALIDADE {tonalidade}");
        foreach (var musica in musicasPorTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
