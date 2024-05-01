using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Core.Enum;
using ADayWithMorte.Shared.Base;

namespace ADayWithMorte.Core.Entities
{
    public class Character : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public EnumTypeCharacters Type { get; set; }
        public bool isAngry { get; set; }

    }
}
