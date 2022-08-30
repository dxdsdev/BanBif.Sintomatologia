using System;

namespace BanBif.Sintomatologia.BE
{
    public class Registro
    {
        public int CodigoRegistro { get; set; }
       public int CodAutogenerado { get; set; }
        public int CodigoFormulario { get; set; }
        public string Puesto { get; set; }
        public string Area { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public bool CheckTerminos { get; set; }
        public DateTime FechaRegitro { get; set; }
        public bool EsColaborador { get; set; }
        public int Estado { get; set; }



    }
}
