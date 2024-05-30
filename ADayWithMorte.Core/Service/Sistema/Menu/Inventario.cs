using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayWithMorte.Shared.Sistema.Menu
{
    public class Inventario : MenuBase
    {
        public Inventario() : base(new List<string> { "Items", "Return", "Use an Item", "Save Game", "Exit Game", "Back to Menu" })
        {
        }

        public override void DisplayTitle()
        {
            //Console.WriteLine("Inventory");
        }

        public override void SelectOption(int selection)
        {
            base.SelectOption(selection);

            // Implementa ações para as opções adicionais
            switch (options[selection])
            {
                case "Return":
                    // Código para voltar ao jogo
                    break;
                case "Use an Item":
                    // Código para usar um item
                    break;
                case "Save Game":
                    // Código para salvar o jogo
                    break;
                case "Exit Game":
                    // Código para sair do jogo
                    break;
                case "Back to Menu":
                    MenuInicial menu = new MenuInicial();
                    menu.DisplayMenu(true);
                    break;
            }
        }
    }
}
