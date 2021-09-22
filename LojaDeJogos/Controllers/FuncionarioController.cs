using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaDeJogos.Models;
using System.Web.Mvc;
using LojaDeJogos.Repositorio;

namespace LojaDeJogos.Controllers
{

    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult IndexFunc()
        {
            var func = new Funcionario()
            {
                CodFunc = 2,
                NomeFunc = "Luiz Ribeiro Silva",
                CPFfunc = "997.148.271-54",
                NascFunc = "06/15/1973",
                EnderecoFunc = "AV. Primeira de Mangueira",
                CelularFunc = "11 946104464",
                EmailFunc = "RibeiroLuiz@gmail.com",
                CargoFunc = "Asistente",
            };

            return View(func);
        }
        Acoes acao = new Acoes();
        [HttpPost]

        public ActionResult CadFunc(Funcionario func)
        {
            acao.CadFunc(func);
            return View(func);
        }

        public ActionResult ListarFunc()
        {
            var ExibirFunc = new Acoes();
            var TodosFunc = ExibirFunc.ListarFunc();
            return View(TodosFunc);
        }
    }
}