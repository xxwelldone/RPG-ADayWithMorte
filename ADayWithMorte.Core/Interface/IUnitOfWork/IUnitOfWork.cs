using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Core.Interface.IRepository;


namespace ADayWithMorte.Core.Interface.IUnitOfWork
{
    public interface IUnitOfWork
    {
        ICharacterRepository CharacterRepository { get; }
        ISaveRepository SaveRepository { get; }
        Task Commit();
        void Dispose();
    }
}
