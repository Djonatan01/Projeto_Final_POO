using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace AgendaProvas
{

    internal class ConexaoBanco
    {
        private MySqlConnection? Conexao;

        // Variavel vcom os valores de conexão com o banco de dados
        private String data_source = "datasource=localhost;" +
                             "username=root;" +
                             "password='';" +
                             "database=bdprovas";

        public void cadastrar(string nome,string email,string senha,string matricula,string periodo,string curso)
        {
            Conexao = null;
            //Criando conexão com o banco de dados
            Conexao = new MySqlConnection(data_source);
            try
            {
                

                string sql = "INSERT INTO usuarios `usuarios`(`nome`, `email`, `senha`, `matricula`, `tipo`," +
                " `periodo`, `curso`)" +
                " VALUES " +
                "('" + nome + "','" + email + "','" + senha + "','" + matricula + "','" +
                "','" + periodo + "','" + curso + "')";

                MySqlCommand comnado = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comnado.ExecuteReader();

                MessageBox.Show("Deu certo!!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "erro");
            }
            finally
            {
                Conexao.Close();
            }

        }
    }
}
