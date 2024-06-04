using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Shared.Base;

namespace ADayWithMorte.Core.Entities
{
    public class Alignment : BaseEntity
    {
        public Character Id_Character { get; set; }
        public int Moralism { get; set; }
        public int Harmonic { get; set; }
        public int Chaotic {  get; set; } 
    }
}
