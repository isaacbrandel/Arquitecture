using Cthulhu.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pantalla_Principal.web.Controllers
{
    public class CateController : Controller
    {
        // GET: Cate
        public ActionResult Index()
        {
            var tagsBL = new TagsBL();
            var ListaTags = tagsBL.Tags();
            return View(ListaTags);
        }
    }
}