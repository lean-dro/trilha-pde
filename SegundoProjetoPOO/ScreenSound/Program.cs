Musica musica1 = new Musica();
musica1.Nome = "Levanta e Anda";
musica1.Artista = "Emicida";
musica1.Duracao = 400;
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.Nome = "Até Que Durou";
musica2.Artista = "Péricles";
musica2.Duracao = 500;
musica2.Disponivel= false;

Musica musica3 = new Musica();
musica3.Nome = "AmarElo";
musica3.Artista = "Emicida";
musica3.Duracao = 750;
musica3.Disponivel = true;

Musica musica4 = new Musica();
musica4.Nome = "A Ordem Natural das Coisas";
musica4.Artista = "Emicida";
musica4.Duracao = 500;
musica4.Disponivel = true;


int somar(int a, int b)=>a+b; // exemplo de lambda


Album albumFavorito = new Album();

albumFavorito.Nome = "AmarElo";
albumFavorito.AdicionarMusica(musica3);
albumFavorito.AdicionarMusica(musica4);

albumFavorito.ExibirMusicasDoAlbum();

