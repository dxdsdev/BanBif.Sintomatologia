using System.Collections.Generic;

namespace BanBif.Sintomatologia.BE
{
    public class ObtenerFormResult
    {
        public int CodigoFormulario { get; set; }
        public string Titulo { get; set; }
        public string DescripcionTitulo { get; set; }
        public string Subtitulo { get; set; }
        public string DescripcionSubtitulo { get; set; }
        public string TerminosCondiciones { get; set; }
        public List<ObtenerGrupoPreguntaResult> GrupoPregunta { get; set; }
    }
}
