using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers {
    public class HomeController : Controller {
        Pessoa pessoa = new Pessoa();

        // GET: Home
        public ActionResult Index() {
            return View(pessoa);
        }

        public ActionResult Contact() {
            return View();
        }

        public ActionResult About() {
            return View();
        }

        public ActionResult Teste() {
            return View();
        }


        [HttpPost]
        public ActionResult Lista(string nome, int codTipo) {
            pessoa.alterarDados(nome, codTipo);
            return View(pessoa);
        }
    }
}