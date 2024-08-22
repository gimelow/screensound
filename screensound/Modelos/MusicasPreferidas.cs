using System.Text.Json;

namespace screensound.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas;
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"essas são as músicas favoritas de {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    //métodos de serialização e geração de arquivos JSON e TXT
    public void GerarAquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"json criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }

    public void GerarArquivoTxt()
    {
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
        using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
        {
            arquivo.WriteLine($"Músicas favoritas do {Nome}");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                arquivo.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }
            Console.WriteLine($"txt criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}