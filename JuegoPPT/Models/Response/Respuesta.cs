using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuegoPPT.Models.Response
{
    public class Respuesta
    {
        public int Succes { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
