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
        public DateTime PlayTime { get; set; }
        public int CurrentChapter { get; set; }
    }
}
