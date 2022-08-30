using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Newtonsoft.Json;
using BanBif.Sintomatologia.Web.Util;
using BanBif.Sintomatologia.BE;

namespace BanBif.Sintomatologia.Web.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult Index()
        {
            ViewBag.URL = ConfigurationManager.AppSettings.Get("UrlApp").ToString();
            return View();
        }

        // GET: Formulario
        public ActionResult Home()
        {
            ViewBag.URL = ConfigurationManager.AppSettings.Get("UrlApp").ToString();
            return View();
        }

        public ActionResult RegistrarColaborador(RegistrarColaboradorRequest request)
        {
            var colaboradorResponse = new RegistrarColaboradorResponse();

            try
            {
                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Sintomatologia/RegistrarColaborador";
                string response = WebApi<RegistrarColaboradorRequest>.RequestWebApi(request, strURL);
                colaboradorResponse = JsonConvert.DeserializeObject<RegistrarColaboradorResponse>(response);
            }
            catch (Exception ex)
            {
                colaboradorResponse.Result = false;
            }
            return Json(colaboradorResponse);
        }

        public ActionResult ObtenerColaborador(ObtenerColaboradorRequest request)
        {
            var colaboradorResponse = new ObtenerColaboradorResponse();

            try
            {
                string strURL = ConfigurationManager.AppSettings["UrlApi"] + "api/Sintomatologia/ObtenerColaborador";
                string response = WebApi<ObtenerColaboradorRequest>.RequestWebApi(request, strURL);
                colaboradorResponse = JsonConvert.DeserializeObject<ObtenerColaboradorResponse>(response);
            }
            catch (Exception ex)
            {
                colaboradorResponse.Result = false;
            }
            return Json(colaboradorResponse);
        }

        public ActionResult ObtenerFormulario(ObtenerFormRequest request)
        {
            var formularioResponse = new ObtenerFormResponse();

            try
            {
                string strURL = ConfigurationManager.AppSettings["UrlApi"] + "api/Sintomatologia/ObtenerFormulario";
                string response = WebApi<ObtenerFormRequest>.RequestWebApi(request, strURL);
                formularioResponse = JsonConvert.DeserializeObject<ObtenerFormResponse>(response);
            }
            catch (Exception ex)
            {
                formularioResponse.Result = false;
            }
            return Json(formularioResponse);
        }

        public ActionResult GuardarRespuesta(GuardarRespuestasRequest request)
        {
            var respuestasResponse = new GuardarRespuestasResponse();

            try
            {
                string strURL = ConfigurationManager.AppSettings["UrlApi"] + "api/Sintomatologia/GuardarRespuesta";
                string response = WebApi<GuardarRespuestasRequest>.RequestWebApi(request, strURL);
                respuestasResponse = JsonConvert.DeserializeObject<GuardarRespuestasResponse>(response);
            }
            catch (Exception ex)
            {
                respuestasResponse.Result = false;
            }
            return Json(respuestasResponse);
        }

    }
}