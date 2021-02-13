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
                oRonda.Gano = 0;

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

        [HttpPost("[action]")]
        public Respuesta ValidarGanador([FromBody] RondaViewModels model)
        {
            Respuesta oR = new Respuesta();

            //1 Piedra ; 2 papel ; 3 tijera
            try
            {
                Models.Ronda oRonda = new Models.Ronda();

                // empate
                if (model.MovimientoJugador1 == model.MovimientoJugador2)
                {
                    //Empate
                }
                else
                {
                    //piedra vs papel
                    if (model.MovimientoJugador1 == 1 && model.MovimientoJugador2 == 2)
                    {
                        //Gana jugador 2
                        GanaJugador2(model);
                    }
                    else
                    {
                        //piedra vs tijera
                        if (model.MovimientoJugador1 == 1 && model.MovimientoJugador2 == 3)
                        {
                            // Gana jugador 1
                            GanaJugador1(model);
                        }
                        else
                        {
                            // papel vs tijera
                            if (model.MovimientoJugador1 == 2 && model.MovimientoJugador2 == 3)
                            {
                                //gana jugador 2
                                GanaJugador2(model);
                            }
                            else
                            {
                                //papel vs piedra
                                if (model.MovimientoJugador1 == 2 && model.MovimientoJugador2 == 1)
                                {
                                    //gana jugador 1
                                    GanaJugador1(model);
                                }
                                else
                                {
                                    //tijera vs piedra
                                    if (model.MovimientoJugador1 == 3 && model.MovimientoJugador2 == 1)
                                    {
                                        //gana jugador 2
                                        GanaJugador2(model);
                                    }
                                    else
                                    {
                                        //tijera vs papel
                                        if (model.MovimientoJugador1 == 3 && model.MovimientoJugador2 == 2)
                                        {
                                            //gana jugador 1
                                            GanaJugador1(model);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                oR.Succes = 1;
            }
            catch (Exception ex)
            {
                oR.Succes = 0;
                oR.Message = ex.Message;
            }
            return oR;
        }

        public void GanaJugador1(RondaViewModels model)
        {
            Models.Ronda oRonda = new Models.Ronda();

            oRonda = db.Ronda
                                    .Where(x => x.CodigoRonda == model.CodigoRonda
                                    && x.CodigoJugador1 == model.CodigoJugador1).Single();
            oRonda.Gano = 1;
            db.Add(oRonda);
            db.SaveChanges();
        }
        public void GanaJugador2(RondaViewModels model)
        {
            Models.Ronda oRonda = new Models.Ronda();

            oRonda = db.Ronda
                                    .Where(x => x.CodigoRonda == model.CodigoRonda
                                    && x.CodigoJugador2 == model.CodigoJugador2).Single();
            oRonda.Gano = 1;
            db.Add(oRonda);
            db.SaveChanges();
        }
    }
}
