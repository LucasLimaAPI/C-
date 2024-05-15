﻿﻿using HarmonySounds.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, List<int>> bandasRegistradas = new();


        Band ira = new Band("Ira!");
        ira.AddNotes(new Evaluation(10));
        ira.AddNotes(new Evaluation(4));
        ira.AddNotes(new Evaluation(7));


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
                    AvaliarUmaBanda();
                    break;
                case 5:
                    ExibirDetalhes();
                    break;
                case -1:
                    Console.WriteLine("You choose exit");
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
            /**
             * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
             */
            Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }

        void RegistrarBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            bandasRegistradas.Add(nomeDaBanda, new List<int>());
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(4000);
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

        void AvaliarUmaBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Avaliar banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
                Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
                Evaluation nota = Evaluation.Parse(Console.ReadLine()!);
                notasDaBanda.Add(nota.Note); // Adicionando a nota à lista de notas da banda
                Console.WriteLine($"\nA nota {nota.Note} foi registrada com sucesso para a banda {nomeDaBanda}");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
        }


        void ExibirDetalhes()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibir detalhes da banda");
            Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
                if (notasDaBanda.Count > 0)
                {
                    double mediaDasNotas = notasDaBanda.Average();
                    Console.WriteLine($"\nA média da banda {nomeDaBanda} é {mediaDasNotas:F2}.");
                }
                else
                {
                    Console.WriteLine($"A banda {nomeDaBanda} não tem notas registradas ainda.");
                }
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
        }

        ExibirOpcoesDoMenu();
    }
}