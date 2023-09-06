
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class JugadorConfiguration : IEntityTypeConfiguration<Jugador>
    {
        public void Configure(EntityTypeBuilder<Jugador> builder)
        {
            builder.HasKey(p=>p.Id);
            builder.Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(p => p.Dorsal)
                .IsRequired()
                .HasMaxLength(3);

            builder.HasOne(p =>p.Persona)
                .WithOne(p=>p.Jugador)
                .HasForeignKey<Jugador>(p=>p.IdPersonaFK)
                .IsRequired();
            
            builder.HasOne(p => p.Posicion)
                .WithMany(p =>p.Jugadores)
                .HasForeignKey(p=>p.IdPosicionFK)
                .IsRequired();
        }
    }
}