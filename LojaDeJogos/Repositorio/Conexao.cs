using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace LojaDeJogos.Repositorio
{
    public class Conexao
    {
        //conectar ao banco
        MySqlConnection cn = new MySqlConnection("Server=localHost;Database=BDLojaDeGame;user=root;pwd=PLMjy_579");
        public static string msg;

        public MySqlConnection ConectarBD()
        {
            try
            {
                //manda abrir
                cn.Open();
            }
            catch(Exception erro)
            {
                //caso algo de errado diz que teve um erro e mostra qual foi o erro
                msg = "Ocorreu um erro ao conectar" + erro.Message;
            }
            return cn;
        }

        public MySqlConnection DesconectarBD()
        {
            try
            {
                cn.Close();
            }
            catch(Exception erro)
            {
                msg="Ocorreu um erro ao conectar" + erro.Message;
            }
            return cn;
        }
    }
}