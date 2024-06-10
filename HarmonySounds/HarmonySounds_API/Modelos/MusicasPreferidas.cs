using HarmonySounds_API.Modelos;
using System.Text.Json;
namespace HarmonySounds_API;

internal class MusicasPreferidas(string nome)
{

    public string? Nome { get; set; } = nome;
    public List<Musica> ListaDeMusicasFavoritas = [];

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        System.Console.WriteLine($"Favoritas da Galera -=-> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            System.Console.WriteLine($"-{musica.Nome} de {musica.Artista}");
        }
        System.Console.WriteLine();

    }
  //Criando um arquivo Json, Criando string Json com JsonSerializer para serializar o arquivo Json.
    public void GerarArquivoJson() 
    {
        string json = JsonSerializer.Serialize(new 
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas 
        });
        string nomeDoArquivo = $"musicas-favoritas{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);//Vamos pegar o path do arquivo json gerado
        System.Console.WriteLine($"O arquivo Json foi criado com sucesso!! {Path.GetFullPath(nomeDoArquivo)}");
    }    

}