using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web;

namespace LojaDeJogos.Models
{
    public class Funcionario
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código do funcionário é obrigatorio")]
        public int CodFunc { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        public string NomeFunc { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Ops, o CPF do funcionário é obrigatorio")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "ops parece que esse CPF não existe ou está errado")]
        public string CPFfunc { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public string NascFunc { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        public string EnderecoFunc { get; set; }

        [Display(Name = "Numero de telefone")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        [RegularExpression(@"\d{2}\s\d{3,12}", ErrorMessage = "ops Parace que este telefone não existe")]
        public string CelularFunc { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        public string EmailFunc { get; set; }

        [Display(Name="CargoFunc")]
        [Required(ErrorMessage = "O cargo do funcionário é obrigatorio")]
        public string CargoFunc { get; set; }
    }
}