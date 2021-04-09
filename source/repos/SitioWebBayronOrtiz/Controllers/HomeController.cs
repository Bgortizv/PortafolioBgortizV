using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWebBayronOrtiz.Controllers
{
    
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Contáctame para contarte todo sobre mis servicios de desarrollo de software";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(Models.Contacto contacto)
        {
            var db = new Models.contactoContext();
            db.Contactos.Add(contacto);

            try
            {
                db.SaveChanges();
                ViewBag.Message = "Mensaje guardado correctamente";
            }
            catch (Exception e)
            {
                ViewBag.Message = "Error al guardar el mensaje por favor inténtalo de nuevo" +e;
               
            }

            return View();
        }

        [Authorize]
        public ActionResult Portafolio()
        { 
            return View();
        }
    }
}