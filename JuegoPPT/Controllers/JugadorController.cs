using JuegoPPT.Models;
using JuegoPPT.Models.Response;
using JuegoPPT.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuegoPPT.Controllers
{
    [Route("api/[controller]")]
    public class JugadorController : Controller
    {
        private Models.JuegoPPTContext db;

        public JugadorController(Models.JuegoPPTContext context)
        {
            db = context;
        }

        [HttpPost("[action]")]
        public Respuesta Add([FromBody] JugadorViewModels model)
        {
            Respuesta oR = new Respuesta();
            try
            {
                Models.Jugador1 oJugador = new Models.Jugador1();
                Models.Jugador2 oJugador2 = new Models.Jugador2();
                
                oJugador.NombreJugador1 = model.NombreJugador1;
                db.Jugador1s.Add(oJugador);
                db.SaveChanges();

                oJugador2.NombreJugador2 = model.NombreJugador2;
                db.Jugador2s.Add(oJugador2);
                db.SaveChanges();
                oR.Succes = 1;
            }
            catch(Exception ex)
            {
                oR.Succes = 0;
                oR.Message = ex.Message;
            }
            return oR;
        }
        
    }
}
