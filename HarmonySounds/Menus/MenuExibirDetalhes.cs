using HarmonySounds.Modelos;

namespace HarmonySounds.Menus
{
    internal class MenuExibirDetalhes : Menu
    {
        public override void Executar(Dictionary<string, Band> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Exibir detalhes da banda");
            Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandasRegistradas.TryGetValue(nomeDaBanda, out Band? value))
            {
                Band banda = value;
                System.Console.WriteLine($"\n A média da banda {nomeDaBanda} é {banda.Media}");
                System.Console.WriteLine("\n Discorgrafia:");
                foreach (Album album in banda.Albuns)
                {
                    System.Console.WriteLine($"{album.Name} -> {album.Media}");
                }
                System.Console.WriteLine("Digite uam tecla para voltar ao menu principal");

                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                System.Console.WriteLine($"\n A banda {nomeDaBanda} Não foi encontrada.");
                System.Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
