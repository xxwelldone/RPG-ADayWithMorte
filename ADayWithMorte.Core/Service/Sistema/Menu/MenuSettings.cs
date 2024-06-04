using ADayWithMorte.Core.Interface.IService.ISistem;
using ADayWithMorte.Shared.Sistema.Menu;

namespace ADayWithMorte.Core.Service.Sistema.Menu
{
    public class MenuSettings : MenuBase, IMenuSettings
    {
        private Func<IMenuManager> _menuManagerFactory;

        public MenuSettings(ISoundSystem soundSystem, string music, Func<IMenuManager> menuManagerFactory)
        : base(new List<string> { "Language", "Sound Volume", "Display Settings", "Save Settings", "Back to Menu" }, soundSystem, music)
        {
            _menuManagerFactory = menuManagerFactory;
        }

        public override void DisplayTitle()
        {
            //Console.WriteLine("Settings");
        }

        public override void SelectOption(int selection)
        {
            base.SelectOption(selection);

            // Implementa ações para as opções adicionais
            switch (options[selection])
            {
                case "Language":
                    // Código para alterar o idioma
                    break;
                case "Sound Volume":
                    // Código para ajustar o volume do som
                    break;
                case "Display Settings":
                    // Código para ajustar as configurações de exibição
                    break;
                case "Save Settings":
                    // Código para ajustar as configurações de salvamento
                    break;
                case "Back to Menu":
                    var menuManager = _menuManagerFactory();
                    menuManager.DisplayInitialMenu();
                    break;
            }
        }
    }
}

