using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

public class Persona: BaseEntity
{
    public string NombrePersona { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; } 
    public string IdTipoNominaFK { get; set; }
    public TipoNomina TipoNomina { get; set; }
    public string IdEquipoFK { get; set; }
    public Equipo Equipo    { get; set; }

    public Jugador Jugador { get; set;}
}
