
using System.Collections.Generic;

namespace BanBif.Sintomatologia.BE
{
    public class PreguntaBE
    {
        public int CodigoPregunta { get; set; }
        public string Pregunta { get; set; }
        public List<Opciones> ListarOpciones { get; set; }
}
}
