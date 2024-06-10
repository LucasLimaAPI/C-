using System.Text.Json.Serialization;

namespace HarmonySounds_API.Modelos;

internal class Musica
{
    
    private readonly string[] tonalidades = ["C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"];

    //Serializar os campos escritos abaixo
    [JsonPropertyName("song")]//Conhecido como anotação, ou @ no java.
    public required string Nome { get; set; }

    [JsonPropertyName("artist") ]
    public required string Artista { get; set; }

    [JsonPropertyName("duration_ms") ]
    public int Duracao { get; set; }

    [JsonPropertyName ("genre")]
    public string? Genero { get; set; } //string? = null; string nao tem nenhum valor atribuido.

    [JsonPropertyName("key")]//Key tem que estar da mesma forma que está na API no caso ele está em minusculo então ele deve ser minusculo aqui também.
    public int Key { get; set; }//O key poderia ser em minuculo aqui, dai não precisaria ser utilizado "JsonPropertyName".

    public string Tonalidade{
        get
        {
            return tonalidades[Key]; 
        }
    }	
    public void ExibirDetalhesDaMusica()
    {
        System.Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Musica: {Nome}");
        System.Console.WriteLine($"Duracao em segundos: {Duracao / 1000}");
        System.Console.WriteLine($"Genero Musical: {Genero}");
        System.Console.WriteLine($"Tonalidade: {Tonalidade}");

    }



}


