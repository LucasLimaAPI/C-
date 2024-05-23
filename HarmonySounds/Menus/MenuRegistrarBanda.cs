using HarmonySounds.Menus;
namespace HarmonySounds.Modelos
{
    internal class MenuRegistrarBanda : Menu
    {
        public override void Executar(Dictionary<string, Band> bandasRegistradas)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            bandasRegistradas.Add(nomeDaBanda, new Band(nomeDaBanda));
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Console.Clear();
        }
    }

}