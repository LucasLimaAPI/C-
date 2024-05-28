using HarmonySounds.Menus;
using HarmonySounds.Modelos;

namespace HarmonySounds;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Band> bandasRegistradas) //override + espaço para carregar as opcoes do que fazer com o override.
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.TryGetValue(nomeDaBanda, out Band? value))
        {
            Band banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Digite a nota para a banda: ");
            string tituloAlbum = Console.ReadLine()!;

            if (banda.Albuns.Any(m => m.Name.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(m => m.Name.Equals(tituloAlbum));
                Console.WriteLine($"Qual a nota que a banda {tituloAlbum}merece: ");
                Evaluation nota = Evaluation.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                banda.AdicionarNota(nota);
                System.Console.WriteLine($"\nA nota {nota.Note} foi registrada com sucesso para o álbum {tituloAlbum}");
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\n O álbum {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();

            }

        }
        else
        {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        }


    }

}
