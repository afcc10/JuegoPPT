using System;
using System.Collections.Generic;

#nullable disable

namespace JuegoPPT.Models
{
    public partial class Juego
    {
        public string CodigoJuego { get; set; }
        public string CodigoJugador1 { get; set; }
        public string CodigoJugador2 { get; set; }

        public virtual Jugador1 CodigoJugador1Navigation { get; set; }
        public virtual Jugador2 CodigoJugador2Navigation { get; set; }
    }
}
