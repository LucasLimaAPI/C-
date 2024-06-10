using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using HarmonySounds_API.Modelos;
namespace HarmonySounds_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            System.Console.WriteLine($"- {genero}");

        }
    } 
    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica=> musica.Artista).Distinct().ToList();
        System.Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero})");
        foreach (var artista in artistasPorGeneroMusical)
        {
            System.Console.WriteLine($"= {artista}");
        }
    }
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas,string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();//sempre que formos pegar um subconjunto utilizar where, ! vai garantir que o valor não é nulo
        System.Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            System.Console.WriteLine($"= {musica.Nome}");
        }
    }

    internal static void FiltrarMusicasEmCsharp(List<Musica> musicas)
    {
        var musicasEmCsharp = musicas.Where((musica) => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();
        System.Console.WriteLine("Musicas em C#");
        foreach (var musica in musicasEmCsharp)
        {
            System.Console.WriteLine($"= {musica}");
        }
    }
}