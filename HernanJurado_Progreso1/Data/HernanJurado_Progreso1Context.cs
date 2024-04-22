using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HernanJurado_Progreso1.Models;

namespace HernanJurado_Progreso1.Data
{
    public class HernanJurado_Progreso1Context : DbContext
    {
        public HernanJurado_Progreso1Context (DbContextOptions<HernanJurado_Progreso1Context> options)
            : base(options)
        {
        }

        public DbSet<HernanJurado_Progreso1.Models.Estudiantes> Estudiantes { get; set; } = default!;
        public DbSet<HernanJurado_Progreso1.Models.Carrera> Carrera { get; set; } = default!;
    }
}
