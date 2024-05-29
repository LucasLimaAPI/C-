using HarmonySounds.Menus;
namespace HarmonySounds.Modelos
{
 internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Band> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Band banda = new Band(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.Clear();
    }
}
}