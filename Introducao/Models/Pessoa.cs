using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introducao.Models {
    public class Pessoa {

        public int id = 1;
        public string nome = "Gustavo";
        public int codTipo = 1;
        public string usuario = "Administrador";

        public void alterarDados(string nome, int codTipo) {
            this.nome = nome;
            this.codTipo = codTipo;
            id++;

            if(codTipo == 1) {
                usuario = "Administrador";
            }
            else {
                usuario = "Usuário";
            }
        }

    }
}