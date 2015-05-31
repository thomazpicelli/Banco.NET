using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Banco.Dados;

namespace Banco.Controllers
{
    public class ContaController : Controller
    {
        //
        // GET: /Conta/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Criar()
        {
            return View();
        }

    }
}
