
using System.Collections.Generic;

namespace BanBif.Sintomatologia.BE
{
    public class GuardarRespuestasRequest
    {
        public string Celular { get; set; }
        public string Puesto { get; set; }
        public string Area { get; set; }
        public string Correo { get; set; }
        public int Anexo { get; set; }
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public int CodigoAuto { get; set; }
        public List<Respuestas> ListarPreguntas { get; set; }
        public bool ChckTerminos { get; set; }
        public int CodigoMensaje { get; set; }
    }
}
