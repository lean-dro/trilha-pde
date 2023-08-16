
// Definindo os convidados
Convidado leandro = new Convidado("Leandro");
Convidado gabriel = new Convidado("Gabriel");
Convidado kelvin = new Convidado("Kelvin");


// Definindo o Podcast
Podcast profissaoDoFuturo = new Podcast(leandro, "Profissão do Futuro");


// Definindo o episódio
Episodio episodio1 = new Episodio(1, "C# na Prática #1", 100, profissaoDoFuturo)
{
    Resumo = "Praticando a POO na prática utilizando a linguagem C#. Nesse episódio iremos ver sobre construtores!"
};

Episodio episodio2 = new Episodio(2, "C# na Prática #2", 120, profissaoDoFuturo)
{
    Resumo = "Praticando a POO na prática utilizando a linguagem C#. Nesse episódio iremos ver sobre ordenagem em Listas!"
};
// Atribuição dos convidados ao episódio
episodio1.AdicionarConvidados(leandro);
episodio1.AdicionarConvidados(gabriel);
episodio1.AdicionarConvidados(kelvin);

episodio2.AdicionarConvidados(leandro);
episodio2.AdicionarConvidados(gabriel);
episodio2.AdicionarConvidados(kelvin);

profissaoDoFuturo.DetalhesPodcast();