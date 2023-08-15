Musica musica1 = new Musica();
musica1.Nome = "Levanta e Anda";
musica1.Artista = "Emicida";
musica1.Duracao = 400;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);
Musica musica2 = new Musica();
musica2.Nome = "Até Que Durou";
musica2.Artista = "Péricles";
musica2.Duracao = 500;
musica2.Disponivel= false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();



