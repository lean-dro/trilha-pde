
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuAvaliarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Avaliar Album");

            Console.Write("Digite o nome da banda que deseja avaliar o álbum: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write($"Digite o nome do álbum da banda {nomeDaBanda}");
                string tituloAlbum = Console.ReadLine()!;

                if (banda.Albuns.Any(a=>a.Nome.Equals(tituloAlbum))) {
                    Album album = banda.Albuns.First(a=>a.Nome.Equals(tituloAlbum));
                    Console.Write($"Nota que o álbum {tituloAlbum} merece: ");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);


                    album.AdicionarNota(nota);

                    Console.WriteLine($"A nota {nota.Nota} foi atribuida ao álbum {tituloAlbum}.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Esse álbum não existe.");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
