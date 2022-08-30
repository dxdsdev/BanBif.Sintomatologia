
using System.Collections.Generic;

namespace BanBif.Sintomatologia.BE
{
   public class ObtenerOpcionesResult
    {
        public string Opcion { get; set; }
        public int Estado { get; set; }
        public int CodigoOpcion { get; set; }

        public string Imagen { get; set; }
        public int Orden { get; set; }
        public int Flagotro { get; set; }
        public int CodigoPreguntaMostrar { get; set; }

        public List<ObtenerRespuestaResult> Respuesta { get; set; }
    }
}
