using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubirYValidarImagen.Controllers
{
    public class ImagenController : Controller
    {
        //
        // GET: /Imagen/
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
	}
}