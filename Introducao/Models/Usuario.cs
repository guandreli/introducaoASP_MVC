using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Introducao.Models {
    public class Usuario {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string nome { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tamanho invalido")]
        public string observacoes { get; set; }
        [Range(18, 20, ErrorMessage = "Idade só de 18 a 70")]
        public int idade { get; set; }
        [Required(ErrorMessage = "Campo email é obrigatório")]
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", ErrorMessage = "Digite um email valido")]
        public string email { get; set; }
        [Required(ErrorMessage = "Campo senha obrigatório")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Senha tem que ter entre 6 a 20 caracteres")]
        public string senha { get; set; }
        [Compare("senha", ErrorMessage = "Senhas não conferem")]
        public string confirmarSenha { get; set; }
    }
}