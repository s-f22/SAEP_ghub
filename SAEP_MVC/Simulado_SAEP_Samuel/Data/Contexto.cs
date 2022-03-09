using Microsoft.EntityFrameworkCore;
using Simulado_SAEP_Samuel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulado_SAEP_Samuel.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<Perfis> Perfil { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<Equipamentos> Equipamentos { get; set; }

    }
}
