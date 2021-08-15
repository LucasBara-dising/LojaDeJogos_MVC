using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;

namespace LojaDeJogos.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult IndexCliente()
        {
            Cliente cli = new Cliente();
            /* {
                 NomeCli = "Luiz Maia",
                 CPFCli = 99999999954,
                 DatNascCli = "03/05/1994",
                 EnderecoCli = "Rua Alencar Almeida",
                 CelularCli = 948722365,
                 EmailCli = "LuizMaia@gmail.com"
             };*/
            return View(cli);
        }
        [HttpPost]
        public ActionResult IndexCliente(Cliente cli) { 
            if (ModelState.IsValid){                 //verifica se os inputs estão preeenchidos corretamnete
                return View("ListaCliente", cli);    //se estiver tudo certo puxa a view que lista os resultados
            } 
            return  View(cli); 
        }
        public ActionResult ListaCliente(Cliente cli)
        {
            return View(cli);
        }
    }
}