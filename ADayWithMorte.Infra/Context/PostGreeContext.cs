using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ADayWithMorte.Infra.Context
{
    public class PostGreeContext : DbContext
    {
        public PostGreeContext(DbContextOptions<PostGreeContext> options) : base(options) { }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Game> Games { get; set; }

    }


}
