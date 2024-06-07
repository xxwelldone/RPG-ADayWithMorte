using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Shared.Base;

namespace ADayWithMorte.Core.Entities
{
    public class Game : BaseEntity
    {
       public ICollection<Chapter> Chapters { get; set; }
    }
    
}
