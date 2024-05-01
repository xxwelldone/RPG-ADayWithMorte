using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Core.Interface.IRepository;
using ADayWithMorte.Core.Interface.IServices;

namespace ADayWithMorte.Core.Service
{
    public class ServiceCharacter : ICharacterService
    {
        private readonly ICharacterRepository _repository;
        public ServiceCharacter(ICharacterRepository repository)
        {
            _repository = repository;
        }
    }
}
