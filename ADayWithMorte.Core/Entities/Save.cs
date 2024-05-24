using ADayWithMorte.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayWithMorte.Core.Entities
{
    public class Save: BaseEntity
    {
        public string UserId { get; set; }
        public TimeSpan PlayTime { get; set; }
        public string CurrentChapter { get; set; }
    }
}
