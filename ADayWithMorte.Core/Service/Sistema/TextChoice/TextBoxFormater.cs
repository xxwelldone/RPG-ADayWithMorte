using ADayWithMorte.Core.Interface.IService.ISistem;
namespace ADayWithMorte.Core.Service.Sistema.TextChoice
{
    public class TextBoxFormater : ITextBoxFormater
    {
        private readonly ISoundSystem _soundSystem;


        public int Moral = 0;
        public int Harmonico = 0;
        public int Colerico = 0;

        public TextBoxFormater(ISoundSystem soundSystem)
        {
            _soundSystem = soundSystem;
        }

        public int ChoiceOption(string text)
        {
            Dictionary<string, string> options = ParseOptions(text);

            int selecao = 0;
            List<string> optionKeys = new List<string>(options.Keys);

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
                    string option = (i == selecao) ? "☠  " + optionKeys[i] : "   " + optionKeys[i];
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
                    string selectedOption = options[optionKeys[selecao]];

                    switch (selectedOption)
                    {
                        case "moral":
                            Moral++;
                            break;
                        case "harmonico":
                            Harmonico++;
                            break;
                        case "colerico":
                            Colerico++;
                            break;
                    }

                    return selecao;
                }
            }
        }


        public void FormatAndPrintSkullBox(string text)
        {
            int consoleWidth = Console.WindowWidth / 2;
            string[] lines = text.Split('\n');
            List<string> formattedLines = new List<string>();
            int maxLength = 0;
            int lineCount = 0;

            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                string formattedLine = "";

                foreach (string word in words)
                {
                    if ((formattedLine + word).Length > consoleWidth || word.EndsWith("."))
                    {
                        formattedLines.Add(formattedLine);
                        maxLength = Math.Max(maxLength, formattedLine.Length);
                        formattedLine = "";
                        lineCount++;

                        if (lineCount >= 7)
                        {
                            MakeBox(formattedLines, maxLength);
                            formattedLines.Clear();
                            maxLength = 0;
                            lineCount = 0;
                            Console.Clear();
                        }
                    }

                    formattedLine += string.Format("{0} ", word);
                }

                if (formattedLine.Length > 0)
                {
                    formattedLines.Add(formattedLine);
                    maxLength = Math.Max(maxLength, formattedLine.Length);
                }
            }

            if (formattedLines.Count > 0)
            {
                MakeBox(formattedLines, maxLength);
            }
        }


        public void MakeBox(List<string> lines, int maxLength)
        {
            string topAndBottomBorder = new string('=', maxLength + 4);
            string sideBorder = "|";
            string skull = "☠ ";

            int paddingLines = (Console.WindowHeight - lines.Count) / 2;
            int paddingSpaces = (Console.WindowWidth - maxLength - 8) / 2;

            for (int i = 0; i < paddingLines; i++)
            {
                Console.WriteLine();
            }

            Console.WriteLine(new string(' ', paddingSpaces) + skull + topAndBottomBorder + skull);
            foreach (string l in lines)
            {
                string paddedLine = l.PadRight(maxLength);
                Console.Write(new string(' ', paddingSpaces) + skull + sideBorder + " ");
                int index = 0;

                CancellationTokenSource cts = new CancellationTokenSource();
                Task soundTask = _soundSystem.TalkSound(cts.Token);

                foreach (char c in paddedLine)
                {
                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        Console.Write(paddedLine.Substring(index));

                        cts.Cancel();
                        break;
                    }

                    Console.Write(c);
                    Thread.Sleep(35);
                    index++;
                }
                soundTask.Wait();
                Console.WriteLine(" " + sideBorder + skull);
            }
            Console.WriteLine(new string(' ', paddingSpaces) + skull + topAndBottomBorder + skull);

            PromptToContinue(paddingSpaces);
        }


        public Dictionary<string, string> ParseOptions(string text)
        {
            var dict = new Dictionary<string, string>();
            var lines = text.Split('\n');

            foreach (var line in lines)
            {
                var parts = line.Split(':');
                var key = parts[1].Split('(')[0].Trim().Trim('"');
                var value = parts[1].Split('(')[1].Trim(')').Trim();

                dict.Add(key, value);
            }

            return dict;
        }

        public void PromptToContinue(int paddingSpaces)
        {
            string triangle = "▼";

            for (int i = 0; i < 130; i++)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                Console.SetCursorPosition(paddingSpaces - 10, Console.CursorTop);
                if (i % 2 == 0)
                {
                    Console.Write("Press Enter to continue..." + triangle);
                }
                else
                {
                    Console.Write("Press Enter to continue... ");
                }
                Thread.Sleep(500);
            }
        }

    }
}
