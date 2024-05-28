using ADayWithMorte.Shared.Sistema.Menu;
using NAudio.Wave;
using System.Text;


namespace ADayWithMorte.Shared.Sistema
{
    public class MenuInicial : MenuBase
    {
        public MenuInicial() : base(new List<string> { "New Game", "Load Game", "Settings", "Exit Game" })
        {
        }

        public override void DisplayTitle()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            int width = Console.WindowWidth;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"
              --------    -- --    ,--.   ,--.
             |   __   |  | '-.  \   \  `.'  / 
             |  |  \  '.-'-'  |  |.-')     /  
             |  |   ' | \| |_.'  (OO  \   /   
             |  |   / :  |  .-.  ||   /  /\_  
             |  '--'  /  |  | |  |`-./  /.__) 
             `-------'   `--' `--'  `--'      ");
            sb.AppendLine(@"  (`\ .-') /`       .-') _    ('-. .-. 
               `.( OO ),'      (  OO) )  ( OO )  / 
            ,--./  .--. ,--') /     '._  ,--. ,--. 
            |      |  | |  |OO)|'------_)|  | |  | 
            |  |   |  |,|  |  \'--.  .--'|  ._.  | 
            |  |/'\|  |_)  |(_/   |  |   |       | 
            |         |,|  |_.'   |  |   |  .-.  | 
            |   / \   (_|  |      |  |   |  | |  | 
            '--'   '--' `--'      `--'   `--' `--'");
            sb.AppendLine(@" _   .-')                _  .-')   .-') _     ('-.   
            ( '.( OO )_             ( \( -O ) (  OO) )  _(  OO)  
             ,--.   ,--.).-'),-----. ,------. /     '._(,------. 
             |   \./   |( O /  .-.  \|   __  \|'--...--)|  .---' 
             |         |/   |  | |  ||  |  | |'--.  .--'|  |     
             |  |\./|  |\_) |  |\|  ||  |_.' |   |  |  (|  '--.  
             |  |   |  |  \ |  | |  ||  .  '.'   |  |   |  .--'  
             |  |   |  |   `'  '-'  '|  |\  \    |  |   |  `---. 
             `--'   `--'     \_____/ `--' '--'   `--'   `------' ");

            Console.WriteLine(sb.ToString());
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
        }

        public override void SelectOption(int selection)
        {
            base.SelectOption(selection);


        }
    }
}
