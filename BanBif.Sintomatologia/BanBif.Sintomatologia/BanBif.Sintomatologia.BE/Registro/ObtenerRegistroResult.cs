
using System;

namespace BanBif.Sintomatologia.BE
{
    public class ObtenerRegistroResult
    {
        public int CodigoRegistro { get; set; }
        public string Puesto { get; set; }
        public string Area { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public bool CheckTerminos {get;set;}
        public DateTime FechaRegistro { get; set; }
        public bool Escolaborador { get; set; }
        public int Estado { get; set; }


}
}
