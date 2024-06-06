using HarmonySounds.Menus;
namespace HarmonySounds.Modelos
{
    internal class MenuMostrarBandasRegistradas : Menu
    {
        public override void Executar(Dictionary<string, Band> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}