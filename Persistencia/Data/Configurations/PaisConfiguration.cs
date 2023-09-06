

using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
            .IsRequired()
            .HasMaxLength(3);
        
        builder.Property( p=> p.NombrePais)
            .IsRequired()
            .HasMaxLength(50);
    }
}
