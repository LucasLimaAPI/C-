using HarmonySounds.Modelos;

namespace HarmonySounds.Menus;

internal abstract class Menu // Classe abstract ela não pode ser instanciada mas pode ser herdada.
{
    public abstract void Executar(Dictionary<string, Band> bandasRegistradas);
    public static void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public override void Executar(Dictionary<string, Band> bandasRegistradas)
    {
        
    }
}