using ScreenSound.Modelos;
using ScreenSound.Menus;

Banda racionais = new("Racionais");
racionais.AdicionarNota(new Avaliacao(10));
racionais.AdicionarNota(new Avaliacao(10));
racionais.AdicionarNota(new Avaliacao(10));

Banda baroes = new("Barões da Pisadinha");
baroes.AdicionarNota(new Avaliacao(10));
baroes.AdicionarNota(new Avaliacao(9));
baroes.AdicionarNota(new Avaliacao(8));

Dictionary<string, Banda> bandasRegistradas = new();


bandasRegistradas.Add("Racionais", racionais);
bandasRegistradas.Add("Barões da Pisadinha", baroes);

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
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
            MenuRegistrarBanda menu1 = new MenuRegistrarBanda();
            menu1.Registrar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 2:
            MenuRegistrarAlbum menu2 = new MenuRegistrarAlbum();
            menu2.Registrar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 3:
            MenuMostrarBandas menu3 = new MenuMostrarBandas();
            menu3.ExibirBandas(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 4:
            AvaliarBanda menu4 = new AvaliarBanda();
            menu4.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 5:
            MenuExibirDetalhes menu5 = new MenuExibirDetalhes();
            menu5.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case -1:
            MenuSair menu6 = new MenuSair();
            menu6.sair();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirOpcoesDoMenu();