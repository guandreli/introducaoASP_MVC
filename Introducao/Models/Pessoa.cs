using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introducao.Models {
    public class Pessoa {
        public int id;
        public string nome { get; set; }
        public int codTipo { get; set; }
        public string usuario { get; set; }

        public void tipoPessoa (int codTipo) {
            if(codTipo == 1) {
                usuario = "Administrador";
            }
            else {
                usuario = "Usuario";
            }
        }

    }
}