using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Sintomatologia.BE
{
   public class ObtenerNombreResponse
    {
        public bool Result { get; set; }
        public string Mensaje { get; set; }
        public ObtenerNombreResult Data { get; set; }

    }
}
