using System.Text;

namespace ADayWithMorte
{
    internal class Util
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
            //ToDo: Fazer música, implementar metodo de musica; Limitador de caixa de console com moldura; Macro de coisas que precisam ser adicionadas;


        }

        public static void PrintSkullBox(string text)
        {
            int consoleWidth = Console.WindowWidth / 2;
            string[] words = text.Split(' ');
            List<string> lines = new List<string>();
            string line = "";
            int maxLength = 0;

            foreach (string word in words)
            {
                if ((line + word).Length > consoleWidth)
                {
                    lines.Add(line);
                    maxLength = Math.Max(maxLength, line.Length);
                    line = "";
                }

                line += string.Format("{0} ", word);
            }

            if (line.Length > 0)
            {
                lines.Add(line);
                maxLength = Math.Max(maxLength, line.Length);
            }

            string topAndBottomBorder = new string('=', maxLength + 4);
            string sideBorder = "|";
            string skull = "☠ ";

            Console.WriteLine(skull + topAndBottomBorder + skull);
            foreach (string l in lines)
            {
                string paddedLine = l.PadRight(maxLength);
                Console.WriteLine(skull + sideBorder + " " + paddedLine + " " + sideBorder.PadLeft(maxLength - paddedLine.Length + 1) + skull);
            }
            Console.WriteLine(skull + topAndBottomBorder + skull);
        }
    }
}
