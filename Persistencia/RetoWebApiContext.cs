

using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistencia
{
    public class RetoWebApiContext : DbContext
    {
        public RetoWebApiContext(DbContextOptions<RetoWebApiContext> options) : base(options)
        {
            
        }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Posicion> Posiciones { get; set;}  
        public DbSet<TipoNomina> TiposNominas {get; set;}


          protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            }


    }

    

}