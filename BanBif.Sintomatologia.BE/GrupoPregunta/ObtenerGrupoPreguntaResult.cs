
using System.Collections.Generic;

namespace BanBif.Sintomatologia.BE
{
    public class ObtenerGrupoPreguntaResult
    {
        public int CodigoGrupo { get; set; }
        public string Grupo { get; set; }
        public int Flagsino { get; set; }
        public int Orden { get; set; }
        public List<ObtenerPreguntaResult> Preguntas {get;set;}


    }
}
