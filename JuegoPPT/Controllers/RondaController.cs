using JuegoPPT.Models.Response;
using JuegoPPT.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuegoPPT.Controllers
{
    [Route("api/[controller]")]
    public class RondaController : Controller
    {
        private Models.JuegoPPTContext db;

        public RondaController(Models.JuegoPPTContext context)
        {
            db = context;
        }

        [HttpPost("[action]")]
        public Respuesta Add([FromBody] RondaViewModels model)
        {
            Respuesta oR = new Respuesta();
            try
            {
                Models.Ronda oRonda = new Models.Ronda();
                oRonda.CodigoRonda = model.CodigoRonda;
                oRonda.CodigoJugador1 = String.IsNullOrEmpty(model.CodigoJugador1) ? null : model.CodigoJugador1;
                oRonda.CodigoJugador2 = String.IsNullOrEmpty(model.CodigoJugador2) ? null : model.CodigoJugador2;
                oRonda.MovimientoJugador1 = (short)model.MovimientoJugador1;
                oRonda.MovimientoJugador2 = (short)model.MovimientoJugador2;
                oRonda.NumeroRonda = (short)model.NumeroRonda;
                oRonda.CodigoJuego = null;


                db.Ronda.Add(oRonda);
                db.SaveChanges();
                oR.Succes = 1;
            }
            catch (Exception ex)
            {
                oR.Succes = 0;
                oR.Message = ex.Message;
            }
            return oR;
        }
    }
}
