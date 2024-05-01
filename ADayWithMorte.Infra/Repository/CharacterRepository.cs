using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Core.Entities;
using ADayWithMorte.Core.Interface.Repository;
using ADayWithMorte.Shared.Base;

namespace ADayWithMorte.Infra.Repository
{
    internal class CharacterRepository : BaseRespository<Character>, ICharacterRepository
    {
    }
}
