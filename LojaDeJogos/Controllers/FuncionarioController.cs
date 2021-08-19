using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaDeJogos.Models;
using System.Web.Mvc;

namespace LojaDeJogos.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            Funcionario func = new Funcionario()
            {
                CodFunc = 1,
                NomeFunc = "Luiz",
                CPFfunc = "999.999.999-54",
                NascFunc = "06 / 15 / 1973",
                EnderecoFunc = "R. Acassias Verdejantes",
                CelularFunc = "11 946104464",
                EmailFunc = "Luiz963@gmail.com",
                CargoFunc = "Gerente",
            };

            return View(func);
        }
        [HttpPost]
        public ActionResult Index(Funcionario func)
        {
            if (ModelState.IsValid)
            {
                return View("Listar", func);
            }
            return View(func);
        }
    }
}