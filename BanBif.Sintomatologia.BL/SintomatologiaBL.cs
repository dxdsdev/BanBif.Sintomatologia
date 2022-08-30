using BanBif.Sintomatologia.BE;
using BanBif.Sintomatologia.DA;
using System;

namespace BanBif.Sintomatologia.BL
{
    public class SintomatologiaBL
    {
        #region LOGIN
        public ValidarLoginResponse ValidarLogin(ValidarLoginRequest request)
        {

            var response = new ValidarLoginResponse();
            try
            {
                var formularioSintomatologiaDA = new SintomatologiaDA();
                var data = formularioSintomatologiaDA.ValidarLogin(request);


                /*DNI EXISTE EN LA BD*/
                if (data.CodigoAuto > 0)
                {
                    response.Data = data;
                    response.Result = true;
                    response.Mensaje = "Existe";
                }/*DNI NO EXISTE*/
                else
                {
                    response.Result = false;
                    response.Mensaje = "No existe";
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }

        #endregion

        #region FORMULARIO
        public ObtenerFormResponse ObtenerFormulario(ObtenerFormRequest request)
        {
            var Response = new ObtenerFormResponse();
            var SintoDA = new SintomatologiaDA();

            Response.Data = SintoDA.ObtenerFormulario(request);
            if (Response.Data.CodigoFormulario > 0)
            {
                Response.Result = true;
            }
            else
            {
                Response.Result = false;
                Response.Mensaje = "No se encontró ningun formulario activo.";
            }

            return Response;
        }

        #endregion

        #region GRUPOPREGUNTA
        public ObtenerGrupoPreguntaResponse ObtenerGrupoPregunta(ObtenerGrupoPreguntaRequest request)
        {

            var response = new ObtenerGrupoPreguntaResponse();
            try
            {
                var formularioSintomatologiaDA = new SintomatologiaDA();
                var data = formularioSintomatologiaDA.ObtenerGrupoPregunta(request);
                response.Data = data;

                if (data.Grupo != "")
                {
                    response.Result = true;
                }
                else
                {
                    response.Mensaje = "Datos No encontrados";
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }

        #endregion

        #region TIPOPREGUNTA
        public ObtenerTipoPreguntaResponse ObtenerTipoPregunta(ObtenerTipoPreguntaRequest request)
        {
            var Response = new ObtenerTipoPreguntaResponse();
            var SintoDA = new SintomatologiaDA();

            Response.Data = SintoDA.ObtenerTipoPregunta(request);
            if (Response.Data.CodigoTipoPregunta > 0)
            {
                Response.Result = true;
            }
            else
            {
                Response.Result = false;
                Response.Mensaje = "No se encontró ningun formulario activo.";
            }

            return Response;
        }
        #endregion

        #region PREGUNTA
        public ObtenerPreguntaResponse ObtenerPregunta(ObtenerPreguntaRequest request)
        {

            var response = new ObtenerPreguntaResponse();
            try
            {
                var formularioSintomatologiaDA = new SintomatologiaDA();
                var data = formularioSintomatologiaDA.ObtenerPregunta(request);
                response.Data = data;

                if (data.CodigoPregunta > 0)
                {
                    response.Result = true;
                }
                else
                {
                    response.Mensaje = "Datos No encontrados";
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }
        #endregion

        #region OPCIONES
        public ObtenerOpcionesResponse ObtenerOpciones(ObtenerOpcionesRequest request)
        {

            var response = new ObtenerOpcionesResponse();
            try
            {
                var formularioSintomatologiaDA = new SintomatologiaDA();
                var data = formularioSintomatologiaDA.ObtenerOpciones(request);
                response.Data = data;

                if (data.CodigoOpcion > 0)
                {
                    response.Result = true;
                }
                else
                {
                    response.Mensaje = "Datos No encontrados";
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }
        #endregion

        #region RESPUESTA
        public ObtenerRespuestaResponse ObtenerRespuesta(ObtenerRespuestaRequest request)
        {

            var response = new ObtenerRespuestaResponse();
            try
            {
                var formularioSintomatologiaDA = new SintomatologiaDA();
                var data = formularioSintomatologiaDA.ObtenerRespuesta(request);
                response.Data = data;

                if (data.CodigoRespuesta > 0)
                {
                    response.Result = true;
                }
                else
                {
                    response.Mensaje = "Datos No encontrados";
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }


        public GuardarRespuestaResponse GuardarRespuesta(GuardarRespuestasRequest request)
        {

            var response = new GuardarRespuestaResponse();
            try
            {
                var formularioSintomatologiaDA = new SintomatologiaDA();
                var resultado = formularioSintomatologiaDA.GuardarRespuesta(request);

                if (resultado.Result == true) {
                    response.Result = true;
                    response.Data = resultado.Data.ToString();
                    response.MensajeHtml = resultado.MensajeHtml;
                }
                else
                {
                    response.Mensaje = "No se pudo guardar la encuesta.";
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }
        #endregion

        #region REGISTRO
        public ObtenerRegistroResponse ObtenerRegistro(ObtenerRegistroRequest request)
        {

            var response = new ObtenerRegistroResponse();
            try
            {
                var formularioSintomatologiaDA = new SintomatologiaDA();
                var data = formularioSintomatologiaDA.ObtenerRegistro(request);
                response.Data = data;

                if (data.CodigoRegistro > 0)
                {
                    response.Result = true;
                }
                else
                {
                    response.Mensaje = "Datos No encontrados";
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }
        #endregion

        #region COLABORADOR
        public ObtenerColaboradorResponse ObtenerColaborador(ObtenerColaboradorRequest request)
        {

            var response = new ObtenerColaboradorResponse();
            try
            {
                var formularioSintomatologiaDA = new SintomatologiaDA();
                var data = formularioSintomatologiaDA.ObtenerColaborador(request);
                response.Data = data;

                if (data != null)
                {
                    response.Result = true;
                }
                else
                {
                    response.Mensaje = "Datos No encontrados";
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }

        public RegistrarColaboradorResponse RegistrarColaborador(RegistrarColaboradorRequest request)
        {
            var formularioSintomatologiaDA = new SintomatologiaDA();
            var response = new RegistrarColaboradorResponse();
            var result = formularioSintomatologiaDA.RegistrarColaborador(request);

            if (result.CodAutogenerado > 0)
            {
                response.Result = true;
                response.Data = result;
                response.Mensaje = "Codigo encontrado";
            }
            else
            {
                response.Mensaje = "Codigo no encontrado";
            }

            return response;
        }

        public ObtenerNombreResponse ObtenerNombre(ObtenerNombreRequest request)
        {

            var response = new ObtenerNombreResponse();
            try
            {
                var formularioSintomatologiaDA = new SintomatologiaDA();
                var data = formularioSintomatologiaDA.ObtenerNombre(request);
                response.Data = data;

                if (data.NombresApellidos.ToString() != "")
                {
                    response.Result = true;
                }
                else
                {
                    response.Mensaje = "Datos No encontrados";
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }
        #endregion

        #region REPORTE

        public int ProcesarRegistros()
        {
            var formularioSintomatologiaDA = new SintomatologiaDA();
            return formularioSintomatologiaDA.ProcesarRegistros();
        }

        #endregion

        #region FECHAREGISTRO
        public ObtenerFechaRegistroResponse ObtenerFechaRegistro(ObtenerFechaRegistroRequest request)
        {

            var response = new ObtenerFechaRegistroResponse();
            try
            {
                var formularioSintomatologiaDA = new SintomatologiaDA();
                var data = formularioSintomatologiaDA.ObtenerFechaRegistro(request);
                response.Data = data;
                
                if (data.ContadorFechaRegistro != 0)
                {
                    response.Result = true;
                }
                else
                {
                    response.Mensaje = "Datos No encontrados";
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }


        #endregion
    }
}
