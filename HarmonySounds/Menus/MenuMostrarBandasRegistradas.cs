using HarmonySounds.Menus;
namespace HarmonySounds.Modelos
{
    internal class MenuMostrarBandasResgistradas : Menu
    {
         public override void Executar(Dictionary<string, Band> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro de álbuns");
            Console.Write("Digite a banda cujo álbum deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            // ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
            Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
            Console.Clear();
        }
    }

}