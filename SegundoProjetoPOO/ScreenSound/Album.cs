class Album {
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine(@"
░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗
██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║
███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║
██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║
██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝");
        Console.WriteLine(Nome);
        foreach (var musica in musicas)
        {
            Console.WriteLine($"- {musica.Nome}");    
        }

        Console.WriteLine($"\nDuração completa {DuracaoTotal} minutos");
    }
}
