using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Core.Entities;
using ADayWithMorte.Core.Interface.IRepository;
using ADayWithMorte.Infra.Context;

namespace ADayWithMorte.Infra.Repository
{
    public class ChapterRepository : BaseRepository<Chapter>, IChapterRepository
    {
        public ChapterRepository(PostGreeContext postGreeContext) : base(postGreeContext)
        {
        }

       
    }
}
