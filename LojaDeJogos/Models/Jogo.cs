using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaDeJogos.Models
{
    public class Jogo
    {
        public int CodGame { get; set; }
        public string NomeGame { get; set; }
        public int VersaoGame { get; set; }
        public string desenvolvedorGame { get; set; }
        public string GeneroGame { get; set; }
        public int EtariaGame { get; set; }
        public string PlataformaGame { get; set;}
        public int AnoLancamentoGame { get; set;}
        public string SinopseJogo { get; set; }
    }
}