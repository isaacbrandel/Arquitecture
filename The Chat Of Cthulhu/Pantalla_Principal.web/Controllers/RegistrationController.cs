﻿using Cthulhu.BL;
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
            var usuarioBL = new UsuariosBL();
            var ListaUsuarios = usuarioBL.ObtenerUsuario();
            
            return View(ListaUsuarios);
        }
    }
}