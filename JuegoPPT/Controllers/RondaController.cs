using JuegoPPT.Models.Response;
using JuegoPPT.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuegoPPT.Controllers
{
    [Route("api/ronda/[controller]")]
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
