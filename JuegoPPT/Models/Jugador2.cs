using System;
using System.Collections.Generic;

#nullable disable

namespace JuegoPPT.Models
{
    public partial class Jugador2
    {
        public Jugador2()
        {
            Juegos = new HashSet<Juego>();
        }

        public string CodigoJugador2 { get; set; }
        public string NombreJugador2 { get; set; }

        public virtual ICollection<Juego> Juegos { get; set; }
    }
}
