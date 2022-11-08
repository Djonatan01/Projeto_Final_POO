using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProvas
{

     public class Cadastrar
    {
        public void cadastrar(string nome,string email,string senha,string matricula,
            string tipo ,string periodo,string curso)
        {
            //Abrir conexão com o banco de dados
            Conn.conectar();

            try
            {
                string sql = "INSERT INTO usuarios (`nome`, `email`, `senha`, `matricula`, `tipo`," +
                " `periodo`, `curso`)" +
                " VALUES (?,?,?,?,?,?,?)";

                MySqlCommand comnado = new MySqlCommand(sql, Conn.conexao);

                comnado.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = nome;
                comnado.Parameters.Add("@email", MySqlDbType.VarChar, 200).Value = email;
                comnado.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = senha;
                comnado.Parameters.Add("@matricula", MySqlDbType.Int64, 14).Value = matricula;
                comnado.Parameters.Add("@tipo", MySqlDbType.VarChar, 50).Value = tipo;
                comnado.Parameters.Add("@periodo", MySqlDbType.VarChar, 10).Value = periodo;
                comnado.Parameters.Add("@curso", MySqlDbType.VarChar, 5).Value = curso;

                //Executar o comando pata inserir dados no banco
                comnado.ExecuteNonQuery();

                //Fechar a conexão com o banco
                Conn.conexao.Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Erro de cadastro entrar em contato com o Admin ", "Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }

        }
    }
}
