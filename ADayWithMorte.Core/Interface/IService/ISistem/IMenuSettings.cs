using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayWithMorte.Core.Interface.IService.ISistem
{
    public interface IMenuSettings
    {
        void DisplayTitle();
        void SelectOption(int selection);
        void DisplayMenu(bool showTitle);
    }
}
