using ADayWithMorte.Core.Entities;
using ADayWithMorte.Core.Interface.IService;
using ADayWithMorte.Core.Interface.IUnitOfWork;

namespace ADayWithMorte.Core.Service
{
    public class SaveService : ISaveService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SaveService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Save>> GetAllSavesAsync()
        {
            return await _unitOfWork.SaveRepository.GetAllAsync();
        }

        public async Task<Save> GetSaveByIdAsync(string id)
        {
            return await _unitOfWork.SaveRepository.GetByAsync(s => s.UserId == id);
        }

        public async Task<Save> SelectSaveAsync()
        {
            //var saves = await GetAllSavesAsync();
            //todo mudar para buscar no banco
            List<Save> saves = new List<Save>
            {
                new Save { UserId = "User1", PlayTime = new DateTime().AddHours(10), CurrentChapter = 1 },
                new Save { UserId = "User2", PlayTime = new DateTime().AddHours(20), CurrentChapter = 2 },
                new Save { UserId = "User3", PlayTime = new DateTime().AddHours(30), CurrentChapter = 3 }
            };

            List<string> options = saves.Select(s => $"Usuário: {s.UserId}, Tempo de Jogo: {s.PlayTime}, Capítulo {s.CurrentChapter}").ToList();

            int selecao = 0;

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
                    string option = (i == selecao) ? "☠  " + options[i] : "   " + options[i];
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
                    return saves.ElementAt(selecao);
                }
            }
        }

    }
}
