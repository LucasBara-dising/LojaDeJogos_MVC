using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LojaDeJogos.Models
{
    public class Cliente
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        public string NomeCli { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "ops parece que esse CPF não existe ou está errado")]
        public string CPFCli { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DatNascCli{
            get {
                return this.datNascCli.HasValue ? this.datNascCli.Value : DateTime.Now; 
            } 
            set {
                this.datNascCli = value; 
            } 
        }
        private DateTime? datNascCli = null;
    

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        public string EnderecoCli { get; set; }

        [Display(Name = "Numero de telefone")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        [RegularExpression(@"\d{2}\s\d{3,12}", ErrorMessage = "ops Parace que este telefone não existe")]
        public string CelularCli { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        public string EmailCli{ get; set; }
    }
}