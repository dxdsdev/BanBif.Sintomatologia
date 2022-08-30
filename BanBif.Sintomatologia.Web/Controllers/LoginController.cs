using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using BanBif.Sintomatologia.BE;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using BanBif.Sintomatologia.Web.Util;

namespace BanBif.Sintomatologia.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            ViewBag.Url = ConfigurationManager.AppSettings.Get("UrlApp").ToString();
            return View();
        }


        public ActionResult IniciarSesion(ValidarLoginRequest request)
        {
            string apiBaseUrl = ConfigurationManager.AppSettings.Get("UrlApi").ToString();
            string apiUrl = apiBaseUrl + "api/Sintomatologia/ValidarLogin";
            var result = new HttpResponseMessage();
            using (var client = new HttpClient())
            {
                var jsonObject = JsonConvert.SerializeObject(request);
                var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                result = client.PostAsync(apiUrl, content).Result;
                var dataObjects = "";

                dataObjects = result.Content.ReadAsStringAsync().Result;

                var resultado = JsonConvert.DeserializeObject<ValidarLoginResponse>(dataObjects);

                return Json(resultado);
            }
        }

        public ActionResult ObtenerFechaRegistro(ObtenerFechaRegistroRequest request)
        {
            var colaboradorResponse = new ObtenerFechaRegistroResponse();

            try
            {
                string strURL = ConfigurationManager.AppSettings["UrlApi"] + "api/Sintomatologia/ObtenerFechaRegistro";
                string response = WebApi<ObtenerFechaRegistroRequest>.RequestWebApi(request, strURL);
                colaboradorResponse = JsonConvert.DeserializeObject<ObtenerFechaRegistroResponse>(response);
            }
            catch (Exception ex)
            {
                colaboradorResponse.Result = false;
            }
            return Json(colaboradorResponse);
        }
    }
}