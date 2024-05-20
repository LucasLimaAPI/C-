using HarmonySounds.Modelos;
using System;
using System.Collections.Generic;

namespace HarmonySounds.Menus
{
    internal class MenuAvaliarBanda : Menu
    {
        public void Executar(Dictionary<string, Band> bandasRegistradas)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Avaliar uma banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Band banda = bandasRegistradas[nomeDaBanda];
                
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
