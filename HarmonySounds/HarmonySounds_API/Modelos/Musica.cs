using System.Text.Json.Serialization;

namespace HarmonySounds_API.Modelos;

internal class Musica
{
    //Serializar os campos escritos abaixo
    [JsonPropertyName("song")]//Conhecido como anotação, ou @ no java.
    public required string Nome { get; set; }

    [JsonPropertyName("artist") ]
    public required string Artista { get; set; }

    [JsonPropertyName("duration_ms") ]
    public int Duracao { get; set; }

    [JsonPropertyName ("genre")]
    public string? Genero { get; set; } //string? = null; string nao tem nenhum valor atribuido.

    public void ExibirDetalhesDaMusica()
    {
        System.Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Musica: {Nome}");
        System.Console.WriteLine($"Duracao em segundos: {Duracao / 1000}");
        System.Console.WriteLine($"Genero Musical: {Genero}");

    }
}


