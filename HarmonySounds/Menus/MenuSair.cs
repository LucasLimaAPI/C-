using System.Diagnostics;
using HarmonySounds.Menus;
using HarmonySounds.Modelos;

namespace HarmonySounds;


internal class MenuSair : Menu
{
  public override void Executar(Dictionary<string, Band> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            System.Console.WriteLine("Voce Escolheu Sair! ");
            Environment.Exit(0); 
            Console.Clear(); 
        }
}