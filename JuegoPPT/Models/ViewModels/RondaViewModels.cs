using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuegoPPT.Models.ViewModels
{
    public class RondaViewModels
    {
        public string CodigoRonda { get; set; }        
        public string CodigoJugador1 { get; set; }
        public string CodigoJugador2 { get; set; }
        public short? MovimientoJugador1 { get; set; }
        public short? MovimientoJugador2 { get; set; }
        public short? NumeroRonda { get; set; }
    }
}
