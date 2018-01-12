using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introducao.Models {
    public class Pessoa {

        public int id { get; set; }
        public string nome { get; set; }
        public int codTipo { get; set; }
        public string usuario { get; set; }

        public void primeiroRegistro() {
            id = 1;
            nome = "Gustavo";
            codTipo = 1;
            usuario = "Administrador";
        }

        public void alterarDados(string nome, int codTipo) {
            this.nome = nome;
            this.codTipo = codTipo;
            if (codTipo == 1) {
                usuario = "Administrador";
            }
            else {
                usuario = "Usuário";
            }
        }

    }
}