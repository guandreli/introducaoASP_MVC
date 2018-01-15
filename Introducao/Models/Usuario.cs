using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models {
    public class Usuario {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string nome { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tamanho invalido")]
        public string observacoes { get; set; }
        [Range(18, 20, ErrorMessage = "Idade só de 18 a 70")]
        public int idade { get; set; }
        [Required(ErrorMessage ="Campo login é obrigatório")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = " ")]
        [RegularExpression(@"[a-z]{5,15}", ErrorMessage ="Não pode ter letras Maiusculas nem numero. Tem que ter entre 3 a 30 caracteres ")]
        [Remote("LoginUnico", "Usuario", ErrorMessage ="Login já existe")]
        public string login { get; set; }
        [Required(ErrorMessage = "Campo email é obrigatório")]
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", ErrorMessage = "Digite um email valido")]
        public string email { get; set; }
        [Required(ErrorMessage = "Campo senha obrigatório")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Senha tem que ter entre 6 a 20 caracteres")]
        public string senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("senha", ErrorMessage = "Senhas não conferem")]
        public string confirmarSenha { get; set; }
    }
}