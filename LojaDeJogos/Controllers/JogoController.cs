using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaDeJogos.Models;
using System.Web.Mvc;
using LojaDeJogos.Repositorio;

namespace LojaDeJogos.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult Indexjogo()
        {
            Jogo game = new Jogo()
            {
                CodGame = 1,
                NomeGame = "GTA",
                VersaoGame = "5",
                desenvolvedorGame = "RockStar",
                GeneroGame = "Tiro",
                EtariaGame = "18",
                PlataformaGame = "PS3,PS4,Xbox 360, Xbox One,PC",
                AnoLancamentoGame = 2013,
                SinopseJogo = "Grand Theft Auto V possui três protagonistas jogáveis: Michael , Trevor e Franklin. Se passa Los Santos: uma metrópole banhadas pelo sol cheias de gurus de auto-ajuda.",
             };
            return View(game);
        }
        Acoes acao = new Acoes();
        [HttpPost]

        public ActionResult Cadjogo(Jogo game)
        {
            acao.Cadjogo(game);
            return View(game);
        }
        public ActionResult ListaJogo()
        {
            var ExibirJogo = new Acoes();
            var TodosGames = ExibirJogo.ListarJogo();
            return View(TodosGames);
        }
    }
}