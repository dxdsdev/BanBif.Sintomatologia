
namespace BanBif.Sintomatologia.BE
{
  public  class RegistrarColaboradorRequest
    {
        public int CodColaborador { get; set; }
        public string NombresApellidos { get; set; }
        public string Documento { get; set; }
        public string Puesto { get; set; }
        public string Area { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string UsuarioWindows { get; set; }
        public bool EsColaborador { get; set; }
        public int Estado { get; set; }

    }
}
