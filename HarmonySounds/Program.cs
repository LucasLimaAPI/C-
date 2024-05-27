using System.Globalization;
using HarmonySounds.Modelos;

namespace HarmonySounds.Menus
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, Band> bandasRegistradas = new();

            Band ira = new("Ira!");
            ira.AdicionarNota(new Evaluation(10));
            ira.AdicionarNota(new Evaluation(4));
            ira.AdicionarNota(new Evaluation(7));

            bandasRegistradas.Add(ira.Name, ira);

            void ExibirLogo()
            {
                Console.WriteLine(@"
    ██╗░░██╗░█████╗░██████╗░███╗░░░███╗░█████╗░███╗░░██╗██╗░░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░░██████╗
    ██║░░██║██╔══██╗██╔══██╗████╗░████║██╔══██╗████╗░██║╚██╗░██╔╝██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔════╝
    ███████║███████║██████╔╝██╔████╔██║██║░░██║██╔██╗██║░╚████╔╝░╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║╚█████╗░
    ██╔══██║██╔══██║██╔══██╗██║╚██╔╝██║██║░░██║██║╚████║░░╚██╔╝░░░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║░╚═══██╗
    ██║░░██║██║░░██║██║░░██║██║░╚═╝░██║╚█████╔╝██║░╚███║░░░██║░░░██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██████╔╝
    ╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═════╝
        
");
                Console.WriteLine("Welcome to HARMONYSOUNDS!");
            }

            void ExibirOpcoesDoMenu()
            {
                ExibirLogo();
                Console.WriteLine("\nDigite 1 para registrar uma banda");
                Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
                Console.WriteLine("Digite 3 para mostrar todas as bandas");
                Console.WriteLine("Digite 4 para avaliar uma banda");
                Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
                Console.WriteLine("Digite -1 para sair");

                Console.Write("\nDigite a sua opção: ");
                string opcaoEscolhida = Console.ReadLine()!;
                if(!int.TryParse(opcaoEscolhida, NumberStyles.Integer, CultureInfo.InvariantCulture, out var opcaoEscolhidaNumerica))
                {
                    Console.WriteLine("Opção inválida");
                    Console.Clear();
                    ExibirOpcoesDoMenu();
                    return;
                }
                Menu menu;
                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        menu = new MenuRegistrarBanda();
                        break;
                    case 2:
                        menu = new MenuMostrarBandasResgistradas();
                        break;
                    case 3:
                        menu = new MenuRegistrarAlbum();
                        break;
                    case 4:
                        menu = new MenuAvaliarBanda();
                        break;
                    case 5:
                        menu = new MenuExibirDetalhes();
                        break;
                    case -1:
                        Console.WriteLine("Você escolheu sair.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida");
                        return;
                }
                menu.Executar(bandasRegistradas);
                ExibirOpcoesDoMenu();
            }
            ExibirOpcoesDoMenu();
        }
    }
}
