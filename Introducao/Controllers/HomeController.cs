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
            var a = new Pessoa();
            a.primeiroRegistro();
            return View(a);
        }

        public ActionResult Contact() {
            return View();
        }

        public ActionResult Sobre() {
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