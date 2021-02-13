using System;
using System.Collections.Generic;

#nullable disable

namespace JuegoPPT.Models
{
    public partial class Ronda
    {
        public string CodigoRonda { get; set; }
        public string CodigoJuego { get; set; }
        public string CodigoJugador1 { get; set; }
        public string CodigoJugador2 { get; set; }
        public short? MovimientoJugador1 { get; set; }
        public short? MovimientoJugador2 { get; set; }
        public short? NumeroRonda { get; set; }
        public short? Gano { get; set; }
    }
}
