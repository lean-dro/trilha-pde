Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


void TestaArrayInt()
{
    int[] idades = new int[5];
    Random randomico = new Random();
    Console.WriteLine(randomico.Next(1,10));
    
    idades[0] = 30;
    idades[1] = 31;
    idades[2] = 32;
    idades[3] = 33;
    idades[4] = 34;
    Console.WriteLine($"Tamanho do Array {idades.Length}");
    int acumulador = 0;
    for (int i =0; i < idades.Length; i++)
    {
        acumulador += idades[i];
        Console.WriteLine($"Indice: [{i}]: {idades[i]}");
    }
    int media = acumulador / idades.Length;
    Console.WriteLine($"Média: "+media);
}

void TesteBuscarPalavra()
{
    string[] jogadores = new string[5];
    for (int i = 0; i < jogadores.Length; i++) 
    {
       
        Console.Write($"Digite seu {(i + 1)}° jogador favorito: ");

        jogadores[i] = Console.ReadLine()!;
    }

    Console.Write("Procure seu jogador favorito:");
    string jogadorFavoritoProcurado = Console.ReadLine()!;


    Console.WriteLine(buscaPalavraNoVetor(jogadores, jogadorFavoritoProcurado));

}

// Desafio
String buscaPalavraNoVetor(string[] vetor, string palavraDesejada){
    bool encontrado = false;
    string aviso = "Não encontrado";
    for (int i = 0; i<vetor.Length; i++)
    {
        if (vetor[i].Equals(palavraDesejada))
        {
            aviso = $"A palavra {palavraDesejada} foi encontrada no índice {i}";
            encontrado = true;
            break;

        }   
    }
    
    return aviso;
}
//
int tamanho = 9;
Array amostra = Array.CreateInstance(typeof(double), tamanho);
for (int i = 0; i < tamanho; i++)
{
    Random randomico = new Random();
    amostra.SetValue(randomico.NextDouble()*(10-1), i);
}

void TestaMediana(Array array)
{
    if (array.Length == 0 || array == null)
    {
        Console.WriteLine("Array inválido");
    }
    else
    {
        double[] amostraOrdenada = (double[])amostra.Clone();
        Array.Sort(amostraOrdenada);

        int tamanhoArray = array.Length;
        int meioArray = tamanhoArray / 2;
        double mediana = tamanho % 2 != 0 ? amostraOrdenada[meioArray] :
            (amostraOrdenada[meioArray] + amostraOrdenada[meioArray - 1]) / 2;

        Console.WriteLine($"A mediana do array passado é: {mediana}");

    }
}
foreach (double numero in amostra)
{
    Console.WriteLine(numero);
}
TestaMediana(amostra);


