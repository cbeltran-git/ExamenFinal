using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Financiera.Logic;

namespace Financiera.AppWeb.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var listarClientes = ClienteBL.Listar();
            return View(listarClientes);
        }
    }
}