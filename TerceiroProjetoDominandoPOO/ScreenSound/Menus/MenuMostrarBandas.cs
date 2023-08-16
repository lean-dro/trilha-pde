using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuMostrarBandas : Menu
    {
        public void ExibirBandas(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
          
        }

        
    }
}
