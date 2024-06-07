using HarmonySounds_API.Modelos;

namespace HarmonySounds_API;

internal class MusicasPreferidas
{

    public string? Nome { get; set; } // ? se refere a um valor nulo
    public List<Musica> listaDeMusicasFavoritas;

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        listaDeMusicasFavoritas = [];

    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        listaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        System.Console.WriteLine($"Favoritas da Galera -=-> {Nome}");
        foreach (var musica in listaDeMusicasFavoritas)
        {
            System.Console.WriteLine($"-{musica.Nome} de {musica.Artista}");
        }
        System.Console.WriteLine();

    }

}