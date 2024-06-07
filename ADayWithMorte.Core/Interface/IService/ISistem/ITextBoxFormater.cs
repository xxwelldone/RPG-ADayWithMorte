using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayWithMorte.Core.Interface.IService.ISistem
{
    public interface  ITextBoxFormater
    {
        void FormatAndPrintSkullBox(string text, ConsoleColor color);
        void MakeBox(List<string> lines, int maxLength);
        void PromptToContinue(int paddingSpaces);
        int ChoiceOption(string text);
        Dictionary<string, string> ParseOptions(string text);
    }
}
