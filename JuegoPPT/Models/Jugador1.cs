﻿using System;
using System.Collections.Generic;

#nullable disable

namespace JuegoPPT.Models
{
    public partial class Jugador1
    {
        public Jugador1()
        {
            Juegos = new HashSet<Juego>();
        }

        public string CodigoJugador1 { get; set; }
        public string NombreJugador1 { get; set; }

        public virtual ICollection<Juego> Juegos { get; set; }
    }
}
