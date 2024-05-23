using HarmonySounds.Modelos;

namespace HarmonySounds.Menus
{
    internal class MenuAvaliarBanda : Menu
    {
        public override void Executar(Dictionary<string, Band> bandasRegistradas)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Avaliar uma banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            
            if (bandasRegistradas.TryGetValue(nomeDaBanda, out Band? value))
            {
                Band banda = value;
                
                Console.Write("Digite a nota para a banda: ");
                int nota = int.Parse(Console.ReadLine()!);
                
                // Adicionar a nota à banda
                banda.AdicionarNota(new Evaluation(nota));
                
                Console.WriteLine($"Avaliação registrada com sucesso para a banda {nomeDaBanda}.");
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            }

            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
