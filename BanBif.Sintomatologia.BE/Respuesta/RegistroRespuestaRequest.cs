
using System.Collections.Generic;

namespace BanBif.Sintomatologia.BE
{
  public class RegistroRespuestaRequest
    {
        public List<Registro> Registro { get; set; }
        public int CodigoGrupo { get; set; }
        public int CodigoPregunta { get; set; }
        public int CodigoOpciones { get; set; }
        public string TextoOtro { get; set; }
        public string Opcion1 { get; set; }
        public string Opcion2 { get; set; }

    }
}
