using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Core.Entities;
using ADayWithMorte.Core.Interface.IService;
using ADayWithMorte.Core.Interface.IUnitOfWork;

namespace ADayWithMorte.Core.Service
{
    internal class ChapterService : IChapterService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChapterService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Chapter Delete(Chapter chapter)
        {
            _unitOfWork.ChapterRepository.Delete(chapter);
            return chapter;
        }

        public async Task<Chapter> GetBy(Expression<Func<Chapter, bool>> expression)
        {
            
           var chapter = await _unitOfWork.ChapterRepository.GetByAsync(expression);
            return chapter;
        }

        public  Chapter Save(Chapter chapter)
        {
            _unitOfWork.ChapterRepository.Create(chapter);
            return chapter;
        }
    }
}
