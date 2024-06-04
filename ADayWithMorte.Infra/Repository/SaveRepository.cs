using ADayWithMorte.Core.Entities;
using ADayWithMorte.Core.Interface.IRepository;
using ADayWithMorte.Infra.Context;

namespace ADayWithMorte.Infra.Repository
{
    public class SaveRepository : BaseRepository<Save>, ISaveRepository
    {
        public SaveRepository(PostGreeContext postGreeContext) : base(postGreeContext)
        {
            // Implemente quaisquer métodos adicionais específicos para Save aqui.
        }
    }
}
