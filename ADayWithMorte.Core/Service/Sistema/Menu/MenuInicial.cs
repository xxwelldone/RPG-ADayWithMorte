using ADayWithMorte.Core.Entities;
using ADayWithMorte.Core.Interface.IService;
using ADayWithMorte.Core.Interface.IService.ISistem;
using ADayWithMorte.Core.Service.Sistema.Menu;
using ADayWithMorte.Shared.Sistema.Menu;
using ADayWithMorte.Shared.Sistema.Timer;
using NAudio.Wave;
using System.Text;


namespace ADayWithMorte.Core.Service
{
    public class MenuInicial : MenuBase, IMenuInicial
    {
        private readonly ISaveService _saveService;
        private IGameTimer _gameTimer;
        private Func<IMenuManager> _menuManagerFactory;

        public MenuInicial(ISoundSystem soundSystem, string music, ISaveService saveService, Func<IMenuManager> menuManagerFactory) :
            base(new List<string> { "New Game", "Load Game", "Settings", "Exit Game" }, soundSystem, music)
        {
            _saveService = saveService;
            _menuManagerFactory = menuManagerFactory;
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

            switch (options[selection])
            {
                case "New Game":
                    _gameTimer = new GameTimer();
                    _gameTimer.Start();
                    //abre um chapterService.RunChapter(1);
                    //deve pegar o arquivo, ler, rodar e traduzir
                    //no text.FormatAndPrintSkullBox (para textos)
                    //e text.ChoiceOption (para opções)
                    break;

                case "Load Game":
                    Save save = _saveService.SelectSaveAsync().Result;
                    _gameTimer = new GameTimer(save.PlayTime);
                    _gameTimer.Start();

                    //abre um chapterService.RunChapter(save.CurrentChapter);
                    //deve pegar o arquivo, ler, rodar e traduzir
                    //no text.FormatAndPrintSkullBox (para textos)
                    //e text.ChoiceOption (para opções)
                    break;

                case "Settings":
                    var menuManager = _menuManagerFactory();
                    menuManager.DisplaySettingsMenu();
                    break;
            }
        }

    }
}
