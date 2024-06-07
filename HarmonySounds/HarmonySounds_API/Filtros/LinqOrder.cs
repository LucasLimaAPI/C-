using HarmonySounds_API.Modelos;

namespace HarmonySounds_API.Filtros;

internal class LinqOrder
{

    public static void ExibirListaDeArtistasOrdenadas(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        System.Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artistasOrdenados)
        {
            System.Console.WriteLine($"- {artista}");
        }
    }

}