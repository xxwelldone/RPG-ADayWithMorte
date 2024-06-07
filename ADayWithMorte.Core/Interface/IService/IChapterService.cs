using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Core.Entities;

namespace ADayWithMorte.Core.Interface.IService
{
    public interface IChapterService
    {
        Task<Chapter> GetBy(Expression<Func<Chapter, bool>> expression);
        Chapter Delete(Chapter chapter);
        Chapter Save(Chapter chapter);


    }
}
