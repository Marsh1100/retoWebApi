using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

public class Jugador: BaseEntity
{
    public string IdPersonaFK { get; set; }
    public Persona Persona { get; set; }
    public string Dorsal { get; set; }
    public string IdPosicionFK { get; set; }
    public Posicion Posicion { get; set; }

    
}
