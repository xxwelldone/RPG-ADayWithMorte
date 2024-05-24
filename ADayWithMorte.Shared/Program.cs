

using ADayWithMorte.Shared.Sound;

namespace ADayWithMorte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISong song = new Song();
            song.Intro();
            string x = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
           int w = Console.WindowWidth/2;
            if (x.Length > w) {
                Console.WriteLine(x.Substring(0, w));
                Console.WriteLine(x.Substring(w, x.Last()));
            } else { Console.WriteLine(x); }


            //Util.MakeTitle();
            //Util.AsQuestions();

        }

    }
}
