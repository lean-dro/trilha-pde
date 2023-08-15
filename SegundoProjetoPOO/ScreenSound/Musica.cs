class Musica{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida
    {
        get
        {
            return $"{Nome} - {Artista}";
        }
    }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Nome}");
        if (Disponivel)
        {
            Console.WriteLine($"Disponível no Plano");
        }
        else
        {
            Console.WriteLine($"Adquira o Plano Plus");
        }
    }
}

