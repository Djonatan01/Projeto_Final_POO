using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AgendaProvas
{
    class Conn
    {
        //Comnando responsavel pela conexao com o banco de dados 
        public static MySqlConnection conexao;

        //Função responsavel pela instruções  a serem executadas
        public static MySqlCommand Comando;
        //Adapter é responsavel por inserir dados em uma datatable
        public static MySqlDataAdapter Adaptador;
        //Responsavel por ligar o banco em controle com a propriedade Datasource
        public static DataTable datTabela;

        public static void conectar()
        {
            try
            {
                // Criando a conexão com o banco de dados
                conexao = new MySqlConnection("server=localhost;uid=root;pwd=");

                conexao.Open();

                MessageBox.Show("Sistema OK");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha"+ ex.Message);
            }
        }
    }
}
