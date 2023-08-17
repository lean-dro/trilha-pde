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

Dictionary<int, Menu> opcoes = new();

opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuMostrarBandas());
opcoes.Add(3, new MenuAvaliarBanda());
opcoes.Add(4, new MenuExibirDetalhes());

opcoes.Add(5, new MenuRegistrarAlbum());
opcoes.Add(6, new MenuAvaliarAlbum());
opcoes.Add(7, new MenuSair());

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
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir os detalhes de uma banda");
    
    Console.WriteLine("Digite 5 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 6 para avaliar o álbum de uma banda");
    Console.WriteLine("Digite 7 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menu = opcoes[opcaoEscolhidaNumerica];
        menu.Executar(bandasRegistradas);
        if(opcaoEscolhidaNumerica < 7)
        {
            ExibirOpcoesDoMenu();
        }
    }else
    {
        Console.WriteLine("Opção inválida");
    }
}
ExibirOpcoesDoMenu();
