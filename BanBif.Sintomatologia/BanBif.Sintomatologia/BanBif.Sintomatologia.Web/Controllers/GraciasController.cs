using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using BanBif.Sintomatologia.BE;
using BanBif.Sintomatologia.Web.Util;
using Newtonsoft.Json;

namespace BanBif.Sintomatologia.Web.Controllers
{
    public class GraciasController : Controller
    {
        // GET: Gracias
        public ActionResult Index()
        {
            ViewBag.Dia = DateTime.Now.ToString("dd/MM/yyyy");
            ViewBag.Hora = DateTime.Now.ToString("HH:mm");
            ViewBag.URL = ConfigurationManager.AppSettings.Get("UrlApp").ToString();
            return View();
        }

        public ActionResult ObtenerNombre(ObtenerNombreRequest request)
        {
            ObtenerNombreResponse contenidoResponse = new ObtenerNombreResponse();

            try
            {
                string strURL = ConfigurationManager.AppSettings["UrlApi"] + "api/Sintomatologia/ObtenerNombre";
                string response = WebApi<ObtenerNombreRequest>.RequestWebApi(request, strURL);
                contenidoResponse = JsonConvert.DeserializeObject<ObtenerNombreResponse>(response);
            }
            catch (Exception ex)
            {
                contenidoResponse.Result = false;
            }
            return Json(contenidoResponse);
        }
    }
}