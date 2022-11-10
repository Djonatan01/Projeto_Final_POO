using AgendaProvas.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProvas.Dao
{
    public class UsuarioDao
    {
        public  void cadastrar(Usuario obj)
        {
            //Abrir conexão com o banco de dados
            Conn.conectar();

            try
            {
                string sql = "INSERT INTO usuarios (`nome`, `email`, `senha`, `matricula`, `tipo`," +
                " `periodo`, `curso`)" +
                " VALUES (?,?,?,?,?,?,?)";

                MySqlCommand comnado = new MySqlCommand(sql, Conn.conexao);

                comnado.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = obj.Nome;
                comnado.Parameters.Add("@email", MySqlDbType.VarChar, 200).Value = obj.Email;
                comnado.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = obj.Senha;
                comnado.Parameters.Add("@matricula", MySqlDbType.Int64, 14).Value = obj.Matricula;
                comnado.Parameters.Add("@tipo", MySqlDbType.VarChar, 50).Value = obj.Tipo;
                comnado.Parameters.Add("@periodo", MySqlDbType.VarChar, 10).Value = obj.Periodo;
                comnado.Parameters.Add("@curso", MySqlDbType.VarChar, 5).Value = obj.Curso;

                //Executar o comando pata inserir dados no banco
                comnado.ExecuteNonQuery();

                //Fechar a conexão com o banco
                Conn.conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de cadastro entrar em contato com o Admin ", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void alterar(Usuario obj)
        {
            //Abrir conexão com o banco de dados
            Conn.conectar();

            try
            {
                string sql = "UPDATE usuarios (`nome`, `email`, `senha`, `matricula`, `tipo`," +
                " `periodo`, `curso`)" +
                " VALUES (?,?,?,?,?,?,?)";

                MySqlCommand comnado = new MySqlCommand(sql, Conn.conexao);

                comnado.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = obj.Nome;
                comnado.Parameters.Add("@email", MySqlDbType.VarChar, 200).Value = obj.Email;
                comnado.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = obj.Senha;
                comnado.Parameters.Add("@matricula", MySqlDbType.Int64, 14).Value = obj.Matricula;
                comnado.Parameters.Add("@tipo", MySqlDbType.VarChar, 50).Value = obj.Tipo;
                comnado.Parameters.Add("@periodo", MySqlDbType.VarChar, 10).Value = obj.Periodo;
                comnado.Parameters.Add("@curso", MySqlDbType.VarChar, 5).Value = obj.Curso;

                //Executar o comando pata inserir dados no banco
                comnado.ExecuteNonQuery();

                //Fechar a conexão com o banco
                Conn.conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de alteração entrar em contato com o Admin ", "Erro de alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void login(string emailLogin, string senhaLogin)
        {

            ArrayList lst_contato = new ArrayList();

            try
            {
                string q = "'%" + emailLogin + "%'";

                //Abrir conexão com o banco de dados
                Conn.conectar();

                string sql = "SELECT * " +
                              "FROM usuarios " +
                              "WHERE email LIKE " + q;


                MySqlCommand comnadoConsulta = new MySqlCommand(sql, Conn.conexao);

                MySqlDataReader reader = comnadoConsulta.ExecuteReader();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(1),//Nome
                        reader.GetString(2),//Senha
                        reader.GetString(3),//e-mail
                        reader.GetString(4),//

                    };
                    var lista = new ListViewItem(row);

                    lst_contato.Add(lista);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de cadastro entrar em contato com o Admin ", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //return lst_contato;
        }
    }
}
