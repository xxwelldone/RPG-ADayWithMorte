using ADayWithMorte.Core.Entities;

namespace ADayWithMorte.Core.Interface.IService
{
    public interface ISaveService
    {
        Task<IEnumerable<Save>> GetAllSavesAsync();
        Task<Save> GetSaveByIdAsync(string id);
        Task<Save> SelectSaveAsync();

    }
}
