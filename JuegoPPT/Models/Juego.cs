using System;
using System.Collections.Generic;

#nullable disable

namespace JuegoPPT.Models
{
    public partial class Juego
    {
        public Juego()
        {
            Ronda = new HashSet<Ronda>();
        }

        public int RowidJuego { get; set; }
        public int? RowidJugador1 { get; set; }
        public int? RowidJugador2 { get; set; }

        public virtual Jugador1 RowidJugador1Navigation { get; set; }
        public virtual Jugador2 RowidJugador2Navigation { get; set; }
        public virtual ICollection<Ronda> Ronda { get; set; }
    }
}
