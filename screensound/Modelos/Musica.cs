using System.Text.Json.Serialization;
namespace screensound.Modelos;
internal class Musica
{
    //desserializando e traduzindo o JSON
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? AnoString { get; set; }

    //transformando anostring em int
    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    //lista de tonalidades de acordo com índices da API
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    //transformando o int do KEY em uma string de tonalidade
    public string Tonalidade { 
        get
        {
            return tonalidades[Key];
        } 
    }
       
    //exibir detalhes de uma música
    public void ExibirDetalhesdaMusica()
    {
        Console.WriteLine($"música: {Nome}");
        Console.WriteLine($"artista: {Artista}");
        Console.WriteLine($"duração em segundos: {Duracao/1000}");
        Console.WriteLine($"gênero: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");

    }
}