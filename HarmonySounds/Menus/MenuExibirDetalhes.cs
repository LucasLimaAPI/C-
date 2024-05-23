using HarmonySounds.Modelos;

namespace HarmonySounds.Menus
{
    internal class MenuExibirDetalhes : Menu
    {
        public override void Executar(Dictionary<string, Band> bandasRegistradas)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibir detalhes da banda");
            Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
            string nomeDaBanda = Console.ReadLine()!;
            
            if (bandasRegistradas.TryGetValue(nomeDaBanda, out Band? value))
            {
                Band banda = value;
                List<Evaluation> notasDaBanda = banda.Notas; // Assuming Notas is the property containing the list of evaluations
                if (notasDaBanda != null && notasDaBanda.Count > 0)
                {
                    double mediaDasNotas = notasDaBanda.Average(e => e.Note);
                    Console.WriteLine($"\nA média da banda {nomeDaBanda} é {mediaDasNotas:F2}.");
                }
                else
                {
                    Console.WriteLine($"A banda {nomeDaBanda} não tem notas registradas ainda.");
                }
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
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
