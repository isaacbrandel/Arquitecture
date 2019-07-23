using Pantalla_Principal.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pantalla_Principal.web.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            var usuario = new RegistrationModel();
            usuario.Nickname = "Mariale";
            usuario.Name = "Alejandra";
            usuario.Lastname = "Fajardo";
            usuario.Correo = "Maryalecf@gmail.com";
            return View(usuario);
        }
    }
}