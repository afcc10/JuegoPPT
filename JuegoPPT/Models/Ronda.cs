using System;
using System.Collections.Generic;

#nullable disable

namespace JuegoPPT.Models
{
    public partial class Ronda
    {
        public int RowidRonda { get; set; }
        public int? RowidJuego { get; set; }
        public int? RowidJugador1 { get; set; }
        public int? RowidJugador2 { get; set; }
        public short? MovimientoJugador1 { get; set; }
        public short? MovimientoJugador2 { get; set; }
        public short? NumeroRonda { get; set; }

        public virtual Juego RowidJuegoNavigation { get; set; }
        public virtual Jugador1 RowidJugador1Navigation { get; set; }
        public virtual Jugador2 RowidJugador2Navigation { get; set; }
    }
}
