using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Core.Entities;
using ADayWithMorte.Core.Interface.IService.ISistem;
using ADayWithMorte.Core.Interface.IUnitOfWork;

namespace ADayWithMorte.Core.Service.Sistema.TextChoice
{
    public class StoryReader : IStoryReader
    {
        private ITextBoxFormater _textBoxFormater;
        private readonly IUnitOfWork _unitOfWork;
        public StoryReader(ITextBoxFormater textBoxFormater)
        {
            _textBoxFormater = textBoxFormater;

        }
        public void ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != null)
                {
                    _textBoxFormater.FormatAndPrintSkullBox(sr.ReadLine(), ConsoleColor.DarkBlue);
                }
            }
        }
        public void ReadChapter(Chapter chapter)
        {
            _textBoxFormater.FormatAndPrintSkullBox(chapter.Description, chapter.Colour);
            Console.ResetColor();

        }
    }
}
