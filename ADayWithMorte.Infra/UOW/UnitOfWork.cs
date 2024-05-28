using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Core.Interface.IRepository;
using ADayWithMorte.Core.Interface.IUnitOfWork;
using ADayWithMorte.Infra.Context;
using ADayWithMorte.Infra.Repository;

namespace ADayWithMorte.Infra.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICharacterRepository? _characterRepository;
        private PostGreeContext _context;
        public UnitOfWork(PostGreeContext context)
        {
            _context = context;
        }
        public ICharacterRepository CharacterRepository
        {
            get
            {
                return _characterRepository ?? new CharacterRepository(_context);
            }
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
