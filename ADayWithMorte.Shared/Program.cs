

using ADayWithMorte.Shared.Sistema;
using ADayWithMorte.Shared.Sound;
using System.Text;

namespace ADayWithMorte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ISong song = new Song();
            DiceSistem dice = new DiceSistem();
            MenuInicial menu = new MenuInicial();

            menu.MakeMenu();

            dice.throwDice();

            // song.Intro();
            // string x = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //int w = Console.WindowWidth/2;
            // if (x.Length > w) {
            //     Console.WriteLine(x.Substring(0, w));
            //     Console.WriteLine(x.Substring(w, x.Last()));
            // } else { Console.WriteLine(x); }


            //Util.MakeTitle();
            //Util.AsQuestions();

        }

    }
}
