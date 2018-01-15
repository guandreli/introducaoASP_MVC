using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Introducao.Models;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario (Usuario usuario) {
            /*if (string.IsNullOrEmpty(usuario.nome)) {
                ModelState.AddModelError("Nome", "Nome ta vaziu");
            }
            if (string.IsNullOrEmpty(usuario.senha)) {
                ModelState.AddModelError("Senha", "Senha ta vazia");
            }
            if (usuario.senha != usuario.confirmarSenha) {
                ModelState.AddModelError("", "Senha não confere");
            }*/

            if (ModelState.IsValid) {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resutado(Usuario usuario) {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login) {
            var bdExemplo = new Collection<string> {
                "blabla",
                "huehue",
                "gustavo"
            };
            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}