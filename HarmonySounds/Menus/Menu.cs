using HarmonySounds.Modelos;

namespace HarmonySounds.Menus;

internal class Menu // Classe abstract ela não pode ser instanciada mas pode ser herdada.
{
    public static void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public virtual void Executar(Dictionary<string, Band> bandasRegistradas)
    {
        Console.Clear();

    }
}