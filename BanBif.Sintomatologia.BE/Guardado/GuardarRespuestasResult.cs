
namespace BanBif.Sintomatologia.BE
{
    public class GuardarRespuestasResult
    {


        public int CodigoRegistro { get; set; }
        public int CodAutogenerado { get; set; }
        public int CodigoFormulario { get; set; }
        public string Puesto { get; set; }
        public string Area { get; set; }
        public bool CheckTerminos { get; set; }
        public bool EsColaborador { get; set; }
        public string MensajeHtml { get; set; }
    }
}
