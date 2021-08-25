using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace LojaDeJogos.Models
{
    public class Jogo
    {
        //codigo
        [Display(Name = "Código*")]
        [Required(ErrorMessage = "Ops o código do jogo tem que ser preenchido")]
        public int CodGame { get; set; }

        //nome jogo
        [Display(Name = "Nome do jogo*")]
        [Required(ErrorMessage = "Ops o nome do jogo tem que ser preenchido")]
        public string NomeGame { get; set; }

        // vesão do jogo
        [Display(Name = "Versao Game")]
        public string VersaoGame { get; set; }

        //desenvolvedor
        [Display(Name = "Desenvolvedor do jogo*")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        public string desenvolvedorGame { get; set; }

        //genero do jogo
        [Display(Name = "Gênero do jogo*")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        public string GeneroGame { get; set; }

        //faixa eteira
        [Display(Name = "Classifição etâria*")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        public string EtariaGame { get; set; }

        //plataforma jogo
        [Display(Name = "Plataforma*")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        public string PlataformaGame { get; set;}

        //ano de lançamento
        [Display(Name = "Ano de lançamento*")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        public int AnoLancamentoGame { get; set;}

        //resumo do jogo
        [Display(Name = "Sinopse*")]
        [Required(ErrorMessage = "Ops este campo tem que ser preenchido")]
        public string SinopseJogo { get; set; }
    }
}