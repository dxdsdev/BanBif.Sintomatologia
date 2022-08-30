using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Sintomatologia.BE
{
    public class ObtenerTipoPreguntaResponse
    {

        public bool Result { get; set; }
        public string Mensaje { get; set; }
        public ObtenerTipoPreguntaResult Data { get; set; }

    }
}
