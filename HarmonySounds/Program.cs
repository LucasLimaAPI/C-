using HarmonySounds.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HarmonySounds.Menus
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, Band> bandasRegistradas = new();

            Band ira = new Band("Ira!");
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
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        RegistrarBanda();
                        break;
                    case 2:
                        RegistrarAlbum();
                        break;
                    case 3:
                        MostrarBandasRegistradas();
                        break;
                    case 4:
                        MenuAvaliarBanda menu4 = new();
                        menu4.Executar(bandasRegistradas);
                        ExibirOpcoesDoMenu();
                        break;
                    case 5:
                        MenuExibirDetalhes menu5 = new MenuExibirDetalhes();
                        menu5.Executar(bandasRegistradas);
                        ExibirOpcoesDoMenu();
                        break;
                    case -1:
                        Console.WriteLine("Você escolheu sair.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

            void RegistrarAlbum()
            {
                Console.Clear();
                ExibirTituloDaOpcao("Registro de álbuns");
                Console.Write("Digite a banda cujo álbum deseja registrar: ");
                string nomeDaBanda = Console.ReadLine()!;
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                // ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
                Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
                System.Threading.Thread.Sleep(4000);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            void RegistrarBanda()
            {
                Console.Clear();
                ExibirTituloDaOpcao("Registro das bandas");
                Console.Write("Digite o nome da banda que deseja registrar: ");
                string nomeDaBanda = Console.ReadLine()!;
                bandasRegistradas.Add(nomeDaBanda, new Band(nomeDaBanda));
                Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
                System.Threading.Thread.Sleep(4000);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            void MostrarBandasRegistradas()
            {
                Console.Clear();
                ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

                foreach (string banda in bandasRegistradas.Keys)
                {
                    Console.WriteLine($"Banda: {banda}");
                }

                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            void ExibirTituloDaOpcao(string titulo)
            {
                int quantidadeDeLetras = titulo.Length;
                string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
                Console.WriteLine(asteriscos);
                Console.WriteLine(titulo);
                Console.WriteLine(asteriscos + "\n");
            }

            void AvaliarBanda()
            {
                Console.Clear();
                ExibirTituloDaOpcao("Avaliar uma banda");
                Console.Write("Digite o nome da banda que deseja avaliar: ");
                string nomeDaBanda = Console.ReadLine()!;
                if (bandasRegistradas.ContainsKey(nomeDaBanda))
                {
                    Band banda = bandasRegistradas[nomeDaBanda];
                    Console.Write($"Digite uma nota para a banda {nomeDaBanda}: ");
                    int nota = int.Parse(Console.ReadLine()!);
                    banda.AdicionarNota(new Evaluation(nota));
                    Console.WriteLine($"Nota {nota} adicionada com sucesso para a banda {nomeDaBanda}");
                }
                else
                {
                    Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
                }
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }

            ExibirOpcoesDoMenu();
        }
    }
}
