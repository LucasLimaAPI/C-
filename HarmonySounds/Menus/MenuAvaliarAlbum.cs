using HarmonySounds.Menus;
using HarmonySounds.Modelos;

namespace HarmonySounds;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Band> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.TryGetValue(nomeDaBanda, out Band? value))
        {
            Band banda = value;

            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;

            if (banda.Albuns.Any(a => a.Name.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Name.Equals(tituloAlbum));
                Console.Write($"Qual a nota que o álbum {tituloAlbum} merece: ");
                Evaluation nota = Evaluation.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Note} foi registrada com sucesso para o álbum {tituloAlbum}");
                Console.Clear();
            } 
            else
            {
                Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
