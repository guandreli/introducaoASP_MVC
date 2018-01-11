using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            var pessoa = new Pessoa();
            pessoa.id = 0;
            pessoa.nome = "Gustavo";
            pessoa.codTipo = 2;
            pessoa.tipoPessoa(pessoa.codTipo);

            ViewBag.id = pessoa.id;
            ViewBag.nome = pessoa.nome;
            ViewBag.tipoPessoa = pessoa.usuario;
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
        public ActionResult Lista(Pessoa pessoa) {
            pessoa.tipoPessoa(pessoa.codTipo);
            return View(pessoa);
        }
    }
}