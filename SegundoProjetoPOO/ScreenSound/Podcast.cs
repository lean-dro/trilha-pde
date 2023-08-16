class Podcast
{
    public Podcast(Convidado host, string nome) { 
        Host = host;
        Nome = nome;
    }    
    public Convidado Host { get; }
    public string Nome { get; }

    private List<Episodio>  listaEpisodios = new List<Episodio>();

    public  int  TotalEpisodios => listaEpisodios.Count;

    
    public void AdicionarEpisodio(Episodio episodio)
    {
        listaEpisodios.Add(episodio);
    }

    public void DetalhesPodcast()
    {

        Console.WriteLine(@"
██████╗░███████╗████████╗░█████╗░██╗░░░░░██╗░░██╗███████╗░██████╗
██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██║░░░░░██║░░██║██╔════╝██╔════╝
██║░░██║█████╗░░░░░██║░░░███████║██║░░░░░███████║█████╗░░╚█████╗░
██║░░██║██╔══╝░░░░░██║░░░██╔══██║██║░░░░░██╔══██║██╔══╝░░░╚═══██╗
██████╔╝███████╗░░░██║░░░██║░░██║███████╗██║░░██║███████╗██████╔╝
╚═════╝░╚══════╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚══════╝╚═════╝░

██████╗░░█████╗░██████╗░░█████╗░░█████╗░░██████╗████████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝
██████╔╝██║░░██║██║░░██║██║░░╚═╝███████║╚█████╗░░░░██║░░░
██╔═══╝░██║░░██║██║░░██║██║░░██╗██╔══██║░╚═══██╗░░░██║░░░
██║░░░░░╚█████╔╝██████╔╝╚█████╔╝██║░░██║██████╔╝░░░██║░░░
╚═╝░░░░░░╚════╝░╚═════╝░░╚════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░");

        Console.WriteLine($"Podcast: {Nome}");
        Console.WriteLine($"Host: {Host.Nome}");
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");

       
        foreach (var episodio in listaEpisodios.OrderBy(episodio=>episodio.Ordem))
        {
            episodio.ExibirDetalhesEpisodio();
        }
    }
}