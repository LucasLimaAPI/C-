using HarmonySounds.Modelos;

namespace HarmonySounds.Menus
{
    internal class MenuAvaliarBanda : Menu
    {
        public override void Executar(Dictionary<string, Band> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Avaliar banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.TryGetValue(nomeDaBanda, out Band? value))
            {
                Band banda = value;
                Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
                Evaluation nota = Evaluation.Parse(Console.ReadLine()!);
                banda.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Note} foi registrada com sucesso para a banda {nomeDaBanda}");
                Console.Clear();
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
}