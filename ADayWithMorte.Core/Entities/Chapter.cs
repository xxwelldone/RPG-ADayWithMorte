using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Shared.Base;

namespace ADayWithMorte.Core.Entities
{
    public class Chapter : BaseEntity
    {
        public int GameId { get; set; }
        public Game? Game { get; set; }
        public ConsoleColor Colour { get; set; }
        public string Description { get; set; }
    }
}
