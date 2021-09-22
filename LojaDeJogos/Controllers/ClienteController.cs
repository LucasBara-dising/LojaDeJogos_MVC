using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;
using LojaDeJogos.Repositorio;

namespace LojaDeJogos.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult IndexCliente()
        {
            var cli = new Cliente()
            {
                 NomeCli = "Luiz Maia",
                 CPFCli = "999.999.999-54",
                 DatNascCli = "03/05/1994",
                 EnderecoCli = "Rua Alencar Almeida",
                 CelularCli = "11 948324484",
                EmailCli = "LuizMaia@gmail.com",
            };

            return View(cli);
        }
        Acoes acao = new Acoes();
        [HttpPost]
        

        public ActionResult CadCli(Cliente cli)
        {
            acao.CadCli(cli);
            return View(cli);
        }

        public ActionResult ListaCliente()
        {
            var ExibirCli = new Acoes();
            var TodosCli = ExibirCli.ListarCli();
            return View(TodosCli);
        }
    }
}