using HarmonySounds;
using HarmonySounds.Menus;
using HarmonySounds.Modelos;

Dictionary<string, Band> bandasRegistradas = [];

Band ira = new("Ira!");
ira.AdicionarNota(new Evaluation(10));
ira.AdicionarNota(new Evaluation(4));
ira.AdicionarNota(new Evaluation(7));

bandasRegistradas.Add(ira.Name, ira);

Dictionary<int, Menu> opcoes = new()
{
    { 1, new MenuRegistrarBanda() },
    { 2, new MenuMostrarBandasRegistradas() },
    { 3, new MenuRegistrarAlbum() },
    { 4, new MenuAvaliarBanda() },
    { 5, new MenuAvaliarAlbum() },
    { 6, new MenuExibirDetalhes() },
    { -1, new MenuSair() }
};

void ExibirLogo()
{
    Console.WriteLine(@"
   
██╗░░██╗░█████╗░██████╗░███╗░░░███╗░█████╗░███╗░░██╗██╗░░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░░██████╗
██║░░██║██╔══██╗██╔══██╗████╗░████║██╔══██╗████╗░██║╚██╗░██╔╝  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔════╝
███████║███████║██████╔╝██╔████╔██║██║░░██║██╔██╗██║░╚████╔╝░  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║╚█████╗░
██╔══██║██╔══██║██╔══██╗██║╚██╔╝██║██║░░██║██║╚████║░░╚██╔╝░░  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║░╚═══██╗
██║░░██║██║░░██║██║░░██║██║░╚═╝░██║╚█████╔╝██║░╚███║░░░██║░░░  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██████╔╝
╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═════╝░
        
");
    Console.WriteLine("Welcome to HARMONYSOUNDS!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3  para registrar o álbum de uma banda");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um album");
    Console.WriteLine("Digite 6 para exibir os detalhes");

    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.TryGetValue(opcaoEscolhidaNumerica, out Menu? menuASerExibido))
    {
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }

    ExibirOpcoesDoMenu();
}
ExibirOpcoesDoMenu();
