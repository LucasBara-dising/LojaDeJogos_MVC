using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojaDeJogos.Repositorio;
using MySql.Data.MySqlClient;
using LojaDeJogos.Models;

namespace LojaDeJogos.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();


        //--------------------------INSERTS------------------------------------------------------------
        //inserte Funcionario
        public void CadFunc(Funcionario func)
        {
            //string data_sistema = Convert.ToDateTime(func.NascFunc).ToString("yyyy-MM-dd");
            
            //define comando
            MySqlCommand cmd = new MySqlCommand("INSERT INTO TBFuncionario VALUES( @CodFunc, @NomeFunc, @CPFfunc, @NascFunc, @EnderecoFunc, @CelularFunc, @EmailFunc, @CargoFunc)", con.ConectarBD());
            cmd.Parameters.Add("@CodFunc", MySqlDbType.Int32).Value = func.CodFunc;
            cmd.Parameters.Add("@NomeFunc", MySqlDbType.VarChar).Value = func.NomeFunc;
            cmd.Parameters.Add("@CPFfunc", MySqlDbType.VarChar).Value = func.CPFfunc;
            cmd.Parameters.Add("@NascFunc", MySqlDbType.VarChar).Value = func.NascFunc;
            cmd.Parameters.Add("@EnderecoFunc", MySqlDbType.VarChar).Value = func.EnderecoFunc;
            cmd.Parameters.Add("@CelularFunc", MySqlDbType.VarChar).Value = func.CelularFunc;
            cmd.Parameters.Add("@EmailFunc", MySqlDbType.VarChar).Value = func.EmailFunc;
            cmd.Parameters.Add("@CargoFunc", MySqlDbType.VarChar).Value = func.CargoFunc;
            //comando para executar comando
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        //Insert jogo
        public void Cadjogo(Jogo game)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO TBJogo VALUES(@CodGame, @NomeGame, @VersaoGame, @desenvolvedorGame, @GeneroGame, @EtariaGame, @PlataformaGame, @AnoLancamentoGame, @SinopseJogo)", con.ConectarBD());
            cmd.Parameters.Add("@CodGame", MySqlDbType.Int32).Value = game.CodGame;
            cmd.Parameters.Add("@NomeGame", MySqlDbType.VarChar).Value = game.NomeGame;
            cmd.Parameters.Add("@VersaoGame", MySqlDbType.VarChar).Value = game.VersaoGame;
            cmd.Parameters.Add("@desenvolvedorGame", MySqlDbType.VarChar).Value = game.desenvolvedorGame;
            cmd.Parameters.Add("@GeneroGame", MySqlDbType.VarChar).Value = game.GeneroGame;
            cmd.Parameters.Add("@EtariaGame", MySqlDbType.VarChar).Value = game.EtariaGame;
            cmd.Parameters.Add("@PlataformaGame", MySqlDbType.VarChar).Value = game.PlataformaGame;
            cmd.Parameters.Add("@AnoLancamentoGame", MySqlDbType.Int32).Value = game.AnoLancamentoGame;
            cmd.Parameters.Add("@SinopseJogo", MySqlDbType.VarChar).Value = game.SinopseJogo;

            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }


        //Insert Cliente
        public void CadCli(Cliente cli)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO TBCliente VALUES(@CPFCli , @NomeCli , @DatNascCli , @EnderecoCli, @CelularCli, @EmailCli)", con.ConectarBD());
            cmd.Parameters.Add("@CPFCli", MySqlDbType.VarChar).Value = cli.CPFCli;
            cmd.Parameters.Add("@NomeCli", MySqlDbType.VarChar).Value = cli.NomeCli;
            cmd.Parameters.Add("@DatNascCli", MySqlDbType.VarChar).Value = cli.DatNascCli;
            cmd.Parameters.Add("@EnderecoCli", MySqlDbType.VarChar).Value = cli.EnderecoCli;
            cmd.Parameters.Add("@CelularCli", MySqlDbType.VarChar).Value = cli.CelularCli;
            cmd.Parameters.Add("@EmailCli", MySqlDbType.VarChar).Value = cli.EmailCli;

            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }


        //=====================================SELECTS========================================

        //Funcionario
        public Funcionario ListarCodFunc(int cod)
        {
            //mostrar os dados
            var comando = String.Format("SELECT * FROM TBFuncionario WHERE CodFunc={0}", cod);
            //manda conectar
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            //executa
            var DadosCodFunc = cmd.ExecuteReader();
            return ListarCodFunc(DadosCodFunc).FirstOrDefault();
        }

        public List<Funcionario> ListarCodFunc(MySqlDataReader dt)
        {
            var AltAl = new List<Funcionario>();
            while (dt.Read())
            {
                var AltTemp = new Funcionario()
                {
                    CodFunc = Int32.Parse(dt["CodFunc"].ToString()),
                    NomeFunc=dt["NomeFunc"].ToString(),
                    CPFfunc = dt["CPFfunc"].ToString(),
                    NascFunc = dt["NascFunc"].ToString(),
                    EnderecoFunc = dt["EnderecoFunc"].ToString(),
                    CelularFunc = dt["CelularFunc"].ToString(),
                    EmailFunc = dt["EmailFunc"].ToString(),
                    CargoFunc = dt["CargoFunc"].ToString(),
                };
                AltAl.Add(AltTemp);
            }

            dt.Close();
            return AltAl;
        }

        public List<Funcionario> ListarFunc()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM TBFuncionario", con.ConectarBD());
            var DadosCodFunc = cmd.ExecuteReader();
            return ListarTodosFunc(DadosCodFunc);
        }

        public List<Funcionario> ListarTodosFunc(MySqlDataReader dt)
        {
            var TodosFunc = new List<Funcionario>();
            while (dt.Read())
            {
                var FuncTemp = new Funcionario()
                {
                    CodFunc = Int32.Parse(dt["CodFunc"].ToString()),
                    NomeFunc = dt["NomeFunc"].ToString(),
                    CPFfunc = dt["CPFfunc"].ToString(),
                    NascFunc = dt["NascFunc"].ToString(),
                    EnderecoFunc = dt["EnderecoFunc"].ToString(),
                    CelularFunc = dt["CelularFunc"].ToString(),
                    EmailFunc = dt["EmailFunc"].ToString(),
                    CargoFunc = dt["CargoFunc"].ToString(),
                };
                TodosFunc.Add(FuncTemp);
            }
            dt.Close();
            return TodosFunc;
        }

        //================Listar Game========================

         public Jogo ListarCodJogo(int cod)
        {
            var comando = String.Format("SELECT * FROM TBJogo WHERE CodGame={0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodGame = cmd.ExecuteReader();
            return ListarCodJogo(DadosCodGame).FirstOrDefault();
        }

        public List<Jogo> ListarCodJogo(MySqlDataReader dt)
        {
            var AltAl = new List<Jogo>();
            while (dt.Read())
            {
                var AltTemp = new Jogo()
                {
                    CodGame = Int32.Parse(dt["CodGame "].ToString()),
                    NomeGame= dt["NomeGame"].ToString(),
                    VersaoGame = dt["VersaoGame "].ToString(),
                    desenvolvedorGame = dt["desenvolvedorGame "].ToString(),
                    GeneroGame = dt["GeneroGame "].ToString(),
                    EtariaGame = dt["EtariaGame "].ToString(),
                    PlataformaGame = dt["PlataformaGame"].ToString(),
                    AnoLancamentoGame = Int16.Parse(dt["AnoLancamentoGame"].ToString()),
                    SinopseJogo = dt["SinopseJogo"].ToString(),
                };
                AltAl.Add(AltTemp);
            }

            dt.Close();
            return AltAl;
        }

        public List<Jogo> ListarJogo()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM TBJogo", con.ConectarBD());
            var DadosCodJogo = cmd.ExecuteReader();
            return ListarTodosJogo(DadosCodJogo);
        }

        public List<Jogo> ListarTodosJogo(MySqlDataReader dt)
        {
            var TodosGames = new List<Jogo>();
            while (dt.Read())
            {
                var GamesTemp = new Jogo()
                {
                    CodGame = Int32.Parse(dt["CodGame"].ToString()),
                    NomeGame= dt["NomeGame"].ToString(),
                    VersaoGame = dt["VersaoGame"].ToString(),
                    desenvolvedorGame = dt["desenvolvedorGame"].ToString(),
                    GeneroGame = dt["GeneroGame"].ToString(),
                    EtariaGame = dt["EtariaGame"].ToString(),
                    PlataformaGame = dt["PlataformaGame"].ToString(),
                    AnoLancamentoGame = Int16.Parse(dt["AnoLancamentoGame"].ToString()),
                    SinopseJogo = dt["SinopseJogo"].ToString(),
                };
                TodosGames.Add(GamesTemp);
            }
            dt.Close();
            return TodosGames;
        }


        //================Listar Cleintes========================

        public Cliente ListarCodCli(int cod)
        {
            var comando = String.Format("SELECT * FROM TBCliente WHERE CPFCli ={0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodCli = cmd.ExecuteReader();
            return ListarCodCli(DadosCodCli).FirstOrDefault();
        }

        public List<Cliente> ListarCodCli(MySqlDataReader dt)
        {
            var AltAl = new List<Cliente>();
            while (dt.Read())
            {
                var AltTemp = new Cliente()
                {
                    CPFCli = dt["CPFCli"].ToString(),
                    NomeCli = dt["NomeCli"].ToString(),
                    DatNascCli = dt["DatNascCli"].ToString(),
                    EnderecoCli = dt["EnderecoCli"].ToString(),
                    CelularCli = dt["CelularCli"].ToString(),
                    EmailCli = dt["EmailCli"].ToString(),
                };
                AltAl.Add(AltTemp);
            }

            dt.Close();
            return AltAl;
        }

        public List<Cliente> ListarCli()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM TBCliente", con.ConectarBD());
            var DadosCodJogo = cmd.ExecuteReader();
            return ListarTodosCli(DadosCodJogo);
        }

        public List<Cliente> ListarTodosCli(MySqlDataReader dt)
        {
            var TodosCli = new List<Cliente>();
            while (dt.Read())
            {
                var CliTemp = new Cliente()
                {
                    CPFCli = dt["CPFCli"].ToString(),
                    NomeCli = dt["NomeCli"].ToString(),
                    DatNascCli = dt["DatNascCli"].ToString(),
                    EnderecoCli = dt["EnderecoCli"].ToString(),
                    CelularCli = dt["CelularCli"].ToString(),
                    EmailCli = dt["EmailCli"].ToString(),
                };
                TodosCli.Add(CliTemp);
            }
            dt.Close();
            return TodosCli;
        }
    }
}