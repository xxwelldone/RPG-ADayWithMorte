using System.Text;

namespace ADayWithMorte
{
    public class Util
    {

        public static void AsQuestions()
        {
            Console.WriteLine("Hello, you seems to be looking a way out of this reality. Are you tired?");
            String IgnoredAnswer = Console.ReadLine();
            Console.WriteLine("No need for anxiety here, I just like to observer people. You just need to say (Yes) or (No). Simply right?");
            String Answer = Console.ReadLine().ToLower();

            switch (Answer)
            {
                case "yes":
                    Console.WriteLine("Oh yes, I can understang this feeling. You know, some say I have no feelings and well," +
                        " that's true but it wasn't till some years ago. Something changed me. It might change you too. Maybe I can help with that.");
                    break;
                case "no":
                    Console.WriteLine("Well, even the best observeres can't help but to failed here and then. " +
                        " You know, I was was tired but something changed me some years ago. People say I have no feelings but that's no true,  I used to have, even the feeling you are having right now of being Wide Awake. " +
                        "It's a good feelings and it's defitnily good you are feeling that way right now...  ");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please just say Yes or No.");
                    break;


            }
        }

        public static void PrintSkullBox(string text)
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
                            PrintBox(formattedLines, maxLength);
                            formattedLines.Clear();
                            maxLength = 0;
                            lineCount = 0;
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
                PrintBox(formattedLines, maxLength);
            }
        }

        public static void PrintBox(List<string> lines, int maxLength)
        {
            string topAndBottomBorder = new string('=', maxLength + 4);
            string sideBorder = "|";
            string skull = "☠ ";
            string triangle = "▼";

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
                Console.WriteLine(new string(' ', paddingSpaces) + skull + sideBorder + " " + paddedLine + " " + sideBorder.PadLeft(maxLength - paddedLine.Length + 1) + skull);
            }
            Console.WriteLine(new string(' ', paddingSpaces) + skull + topAndBottomBorder + skull);

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
                    Console.Write("Pressione Enter para continuar..." + triangle);
                }
                else
                {
                    Console.Write("Pressione Enter para continuar... ");
                }
                System.Threading.Thread.Sleep(500);
            }
        }

        public static void OptionChoice(Dictionary<string, string> options, ref int moral, ref int harmonico, ref int colerico)
        {
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
                            moral++;
                            break;
                        case "harmonico":
                            harmonico++;
                            break;
                        case "colerico":
                            colerico++;
                            break;
                    }

                    return;
                }
            }
        }
        public static Dictionary<string, string> ParseOptions(string text)
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
    }
}
