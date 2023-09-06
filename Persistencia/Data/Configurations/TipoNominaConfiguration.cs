
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class TipoNominaConfiguration : IEntityTypeConfiguration<TipoNomina>
    {
        public void Configure(EntityTypeBuilder<TipoNomina> builder)
        {
            builder.HasKey(p=>p.Id);
            builder.Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(p => p.NombreNomina)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}