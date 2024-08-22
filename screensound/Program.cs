using System.Text.Json;
using screensound.Modelos;
using screensound.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        //requisição para a API
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //método para exibir detalhes da músicas
        //musicas[0].ExibirDetalhesdaMusica();

        //filtros LINQ
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqFilter.FiltrarArtistaPorGenero(musicas, "pop");
        //LinqFilter.FiltrarMusicasDoArtista(musicas, "Michael Jackson");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2012);
        //LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C#");

        //ordenação LINQ
        //LinqOrder.ExibirListaDeArtistas(musicas);
           
        //método para adicionar e exibir músicas favoritas
        //var MusicaPreferidaDaGi = new MusicasPreferidas("Gi");
        //MusicaPreferidaDaGi.AdicionarMusicasFavoritas(musicas[1]);
        //MusicaPreferidaDaGi.AdicionarMusicasFavoritas(musicas[377]);
        //MusicaPreferidaDaGi.AdicionarMusicasFavoritas(musicas[4]);
        //MusicaPreferidaDaGi.AdicionarMusicasFavoritas(musicas[6]);
        //MusicaPreferidaDaGi.AdicionarMusicasFavoritas(musicas[1467]);
        //MusicaPreferidaDaGi.ExibirMusicasFavoritas();      
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

