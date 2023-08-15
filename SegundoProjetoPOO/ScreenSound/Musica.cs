class Musica{
    public string nome;
    public string artista;
    public int duracao;
    public bool Disponivel { get; set; }

   

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {nome}");
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

