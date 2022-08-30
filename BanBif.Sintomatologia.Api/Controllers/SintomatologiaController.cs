using BanBif.Sintomatologia.BE;
using BanBif.Sintomatologia.BL;
using System.Web.Http;

namespace BanBif.Sintomatologia.Api.Controllers
{
    public class SintomatologiaController : ApiController
    {
        #region LOGIN
        [Route("api/Sintomatologia/ValidarLogin")]
        [HttpPost]
        public IHttpActionResult ValidarLogin(ValidarLoginRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.ValidarLogin(request));
        }

        #endregion

        #region FORMULARIO

        [Route("api/Sintomatologia/ObtenerFormulario")]
        [HttpPost]
        public IHttpActionResult ObtenerFormulario(ObtenerFormRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.ObtenerFormulario(request));
        }
        #endregion

        #region GRUPOPREGUNTA

        [Route("api/Sintomatologia/ObtenerGrupoPregunta")]
        [HttpPost]
        public IHttpActionResult ObtenerGrupoPregunta(ObtenerGrupoPreguntaRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.ObtenerGrupoPregunta(request));
        }

        #endregion

        #region TIPOPREGUNTA

        [Route("api/Sintomatologia/ObtenerTipoPregunta")]
        [HttpPost]
        public IHttpActionResult ObtenerTipoPregunta(ObtenerTipoPreguntaRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.ObtenerTipoPregunta(request));
        }
        #endregion

        #region PREGUNTA

        [Route("api/Sintomatologia/ObtenerPregunta")]
        [HttpPost]
        public IHttpActionResult ObtenerPregunta(ObtenerPreguntaRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.ObtenerPregunta(request));
        }


        #endregion

        #region OPCION
        [Route("api/Sintomatologia/ObtenerOpciones")]
        [HttpPost]
        public IHttpActionResult ObtenerOpciones(ObtenerOpcionesRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.ObtenerOpciones(request));
        }
        #endregion

        #region RESPUESTA
        [Route("api/Sintomatologia/ObtenerRespuesta")]
        [HttpPost]
        public IHttpActionResult ObtenerRespuesta(ObtenerRespuestaRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.ObtenerRespuesta(request));
        }

        [Route("api/Sintomatologia/GuardarRespuesta")]
        [HttpPost]
        public IHttpActionResult GuardarRespuesta(GuardarRespuestasRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.GuardarRespuesta(request));
        }
        #endregion

        #region REGISTRO
        [Route("api/Sintomatologia/ObtenerRegistro")]
        [HttpPost]
        public IHttpActionResult ObtenerRegistro(ObtenerRegistroRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.ObtenerRegistro(request));
        }
        #endregion

        #region COLABORADOR   
        [Route("api/Sintomatologia/ObtenerColaborador")]
        [HttpPost]
        public IHttpActionResult ObtenerColaborador(ObtenerColaboradorRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.ObtenerColaborador(request));
        }

        [Route("api/Sintomatologia/RegistrarColaborador")]
        [HttpPost]
        public IHttpActionResult RegistrarColaborador(RegistrarColaboradorRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.RegistrarColaborador(request));
        }

        [Route("api/Sintomatologia/ObtenerNombre")]
        [HttpPost]
        public IHttpActionResult ObtenerNombre(ObtenerNombreRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.ObtenerNombre(request));
        }

        #endregion

        #region REPORTE
        [Route("api/Sintomatologia/ProcesarRegistros")]
        [HttpPost]
        public IHttpActionResult ProcesarRegistros()
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.ProcesarRegistros());
        }


        #endregion

        #region FECHAREGISTRO
        [Route("api/Sintomatologia/ObtenerFechaRegistro")]
        [HttpPost]
        public IHttpActionResult ObtenerFechaRegistro(ObtenerFechaRegistroRequest request)
        {
            var oBL = new SintomatologiaBL();
            return Json(oBL.ObtenerFechaRegistro(request));
        }

        #endregion
    }
}
