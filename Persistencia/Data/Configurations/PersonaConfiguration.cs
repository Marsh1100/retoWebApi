
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(p=>p.Id);
            builder.Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(p => p.NombrePersona)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.Apellido)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.FechaNacimiento);

            builder.HasOne(p => p.TipoNomina)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdTipoNominaFK);
            
            builder.HasOne(p => p.Equipo)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdEquipoFK);

           
        }
    }
}