using ADayWithMorte.Shared.Sistema.Menu;
using ADayWithMorte.Shared.Sistema;
using ADayWithMorte.Shared.Sound;
using System.Text;
using ADayWithMorte.Shared.Sistema.Timer;
using ADayWithMorte.Shared.Sistema.LuckSistem;

namespace ADayWithMorte.Main.Config
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DiceSistem dice = new DiceSistem();
            MenuInicial menu = new MenuInicial();
            Inventario inventario = new Inventario();
            GameTimer gameTimer = new GameTimer();
            gameTimer.Start();

            menu.DisplayMenu(true);
            inventario.DisplayMenu(false);

            dice.throwDice();
        }
    }
}
