
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class EquipoConfiguration : IEntityTypeConfiguration<Equipo>
    {
        public void Configure(EntityTypeBuilder<Equipo> builder)
        {
            builder.HasKey(p=>p.Id);
            builder.Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(p => p.NombreEquipo)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(p=>p.Pais)
                .WithMany(p => p.Equipos)
                .HasForeignKey(p => p.IdPaisFK);
        }
    }
}