using BanBif.Sintomatologia.DA;
using System;

namespace BanBif.Sintomatologia.RepService
{
    class Program
    {
        static void Main(string[] args)
        {
            var SintoDA = new SintomatologiaDA();
            var Respuesta = SintoDA.ProcesarRegistros();
            Console.WriteLine("Nro Registros procesados: " + Respuesta);
            //Console.ReadLine();
        }
    }
}
