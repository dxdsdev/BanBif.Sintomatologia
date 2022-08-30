
using System.Collections.Generic;

namespace BanBif.Sintomatologia.BE
{
    public class ObtenerPreguntaResult
    {

        public int CodigoPregunta { get; set; }
        public int CodigoTipoPregunta { get; set; }
        public string Pregunta { get; set; }
        public string TextoApoyo { get; set; }
        public int Estado { get; set; }
        public int Orden { get; set; }
        public int Obligatorio { get; set; }
        public bool Dependiente { get; set; }
        public List<ObtenerOpcionesResult> Opciones { get; set; }

        public List<ObtenerRespuestaResult> Respuestas { get; set; }
    }
}
