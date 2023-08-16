class Genero
{
    private List<Album> albuns = new List<Album>();

    public string Nome { get; set; }
    public int QuantidadeDeAlbuns => albuns.Count;

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDetalhesDoGenero()
    {
        Console.WriteLine($"**********{Nome}**********");
        Console.WriteLine($"Álbuns do gênero ({QuantidadeDeAlbuns}):");
        foreach (var album in albuns)
        {
            Console.WriteLine($"- {album.Nome} - {album.DuracaoTotal} minutos");
        }
    }
}