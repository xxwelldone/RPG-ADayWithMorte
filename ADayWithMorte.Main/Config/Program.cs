using ADayWithMorte.Shared.Sistema.Menu;
using ADayWithMorte.Shared.Sistema;
using ADayWithMorte.Shared.Sound;
using System.Text;

namespace ADayWithMorte.Main.Config
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ISong song = new Song();
            DiceSistem dice = new DiceSistem();
            MenuInicial menu = new MenuInicial();
            Inventario inventario = new Inventario();


            menu.DisplayMenu(true);
            inventario.DisplayMenu(false);

            //dice.throwDice();
        }
    }
}
