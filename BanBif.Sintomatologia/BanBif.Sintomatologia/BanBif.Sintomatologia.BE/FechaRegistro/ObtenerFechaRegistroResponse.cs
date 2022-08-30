using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Sintomatologia.BE
{
    public class ObtenerFechaRegistroResponse
    {

        public bool Result { get; set; }
        public ObtenerFechaRegistroResult Data { get; set; }
        public string Mensaje { get; set; }

    }
}
