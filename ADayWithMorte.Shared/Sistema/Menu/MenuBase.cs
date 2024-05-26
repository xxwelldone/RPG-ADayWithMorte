
using NAudio.Wave;

namespace ADayWithMorte.Shared.Sistema.Menu
{
    public abstract class MenuBase
    {
        protected List<string> options;

        public MenuBase(List<string> options)
        {
            this.options = options;
        }

        public abstract void DisplayTitle();

        public int DisplayOptions()
        {
            int selecao = 0;

            while (true)
            {
                Console.Clear();

                int paddingLines = (Console.WindowHeight - options.Count) / 2;

                for (int i = 0; i < paddingLines; i++)
                {
                    Console.WriteLine();
                }

                for (int i = 0; i < options.Count; i++)
                {
                    string option = (i == selecao) ? "☠  " + options[i] : "   " + options[i];
                    string paddedOption = option.PadLeft((Console.WindowWidth + option.Length) / 2);

                    Console.WriteLine(paddedOption);
                }

                ConsoleKeyInfo cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.UpArrow)
                {
                    selecao = (selecao > 0) ? selecao - 1 : options.Count - 1;
                }
                else if (cki.Key == ConsoleKey.DownArrow)
                {
                    selecao = (selecao + 1) % options.Count;
                }
                else if (cki.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    return selecao;
                }
            }

        }

        public virtual void SelectOption(int selection)
        {
            if (options[selection] == "Exit Game")
            {
                Util.PrintSkullBox("See you soon...");
                Environment.Exit(0);
            }
        }
          
        public void PlayAudioFile()
        {
            string audioFile = @"..\..\..\..\ADayWithMorte.Shared\Sound\intro\teste.wav";

            using (var audioOutput = new WaveOutEvent())
            {
                using (var audioFileReader = new AudioFileReader(audioFile))
                {
                    audioOutput.Init(audioFileReader);
                    audioOutput.Play();

                    while (audioOutput.PlaybackState == PlaybackState.Playing)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            break;
                        }
                    }

                    audioOutput.Stop();
                }
            }
        }
        public void DisplayMenu(bool showTitle)
        {
            if (showTitle)
            {
                DisplayTitle();
                PlayAudioFile();
            }
            
            int selection = DisplayOptions();
            SelectOption(selection);
        }
    }
}
