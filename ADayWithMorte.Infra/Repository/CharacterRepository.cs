
using ADayWithMorte.Core.Entities;
using ADayWithMorte.Core.Interface.IRepository;
using ADayWithMorte.Infra.Context;


namespace ADayWithMorte.Infra.Repository
{
    internal class CharacterRepository : BaseRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(PostGreeContext context) : base(context)
        {

        }
    }
}
