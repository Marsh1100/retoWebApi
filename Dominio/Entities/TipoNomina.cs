

namespace Dominio.Entities
{
    public class TipoNomina: BaseEntity
    {
        public string NombreNomina { get; set; }

        public ICollection<Persona> Personas { get; set; }
    }
}