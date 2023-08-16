class Episodio
{
    public Episodio(int ordem, string titulo, int duracaoEmMinutos, Podcast podcast)
    {

        Ordem = ordem;
        Titulo = titulo;
        DuracaoEmMinutos = duracaoEmMinutos;
        Podcast = podcast;
        Podcast.AdicionarEpisodio(this);
    }
    
    public Podcast Podcast { get; }
    public int DuracaoEmMinutos { get; }
    public int Ordem { get; }
    public string Resumo { get; set; }
    public string Titulo { get; }

    private List<Convidado>  listaConvidados = new List<Convidado>();


    public void AdicionarConvidados(Convidado convidado)
    {
        listaConvidados.Add(convidado);
    }

    public void ExibirDetalhesEpisodio()
    {

        Console.WriteLine(@"
███████████████████████████████████████████████
█▄─▄▄▀█▄─▄▄─█─▄─▄─██▀▄─██▄─▄███─█─█▄─▄▄─█─▄▄▄▄█
██─██─██─▄█▀███─████─▀─███─██▀█─▄─██─▄█▀█▄▄▄▄─█
▀▄▄▄▄▀▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀▄▀▄▀▄▄▄▄▄▀▄▄▄▄▄▀
███████████████████████████████████████████
█▄─▄▄─█▄─▄▄─█▄─▄█─▄▄▄▄█─▄▄─█▄─▄▄▀█▄─▄█─▄▄─█
██─▄█▀██─▄▄▄██─██▄▄▄▄─█─██─██─██─██─██─██─█
▀▄▄▄▄▄▀▄▄▄▀▀▀▄▄▄▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▄▀▀▄▄▄▀▄▄▄▄▀");
        Console.WriteLine($"Podcast: {Podcast.Nome}");
        Console.WriteLine($"Ordem: {Ordem}");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Resumo: {Resumo}");
        Console.WriteLine($"Duração (em minutos): {DuracaoEmMinutos}");

        Console.WriteLine("\nConvidados:");
        foreach (var convidado in listaConvidados)
        {
            Console.WriteLine($"- {convidado.Nome}");
        }
        
    }




}