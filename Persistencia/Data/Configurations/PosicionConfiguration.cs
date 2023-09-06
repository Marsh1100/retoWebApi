
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class PosicionConfiguration : IEntityTypeConfiguration<Posicion>
    {
        public void Configure(EntityTypeBuilder<Posicion> builder)
        {
            builder.HasKey(p=>p.Id);
            builder.Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(p => p.NombrePosicion)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}