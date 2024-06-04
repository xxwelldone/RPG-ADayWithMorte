
using ADayWithMorte.Core.Interface.IService.ISistem;

namespace ADayWithMorte.Core.Service.Sistema.Menu
{
    public class MenuManager : IMenuManager
    {
        private readonly IMenuInicial _menuInicial;
        private readonly IMenuSettings _menuSettings;
        private readonly IMenuInventory _menuInventory;



        public MenuManager(IMenuInicial menuInicial, IMenuSettings menuSettings, IMenuInventory menuInventory)
        {
            _menuInicial = menuInicial;
            _menuSettings = menuSettings;
            _menuInventory = menuInventory;
        }

        public void DisplayInitialMenu()
        {
            _menuInicial.DisplayMenu(true);
        }

        public void DisplaySettingsMenu()
        {
            _menuSettings.DisplayMenu(false);
        }

        public void DisplayInventoryMenu()
        {
            _menuInventory.DisplayMenu(false);
        }
    }

}
