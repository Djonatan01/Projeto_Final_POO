using AgendaProvas.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProvas.Dao
{
    public class UsuarioDao
    {
        public UsuarioDao() 
        {
            //Abrir conexão com o banco de dados
            Conn.conectar();
        }

        #region Método cadastrar usuário
        public void cadastrarUsuario(Usuario obj)
        {
            try
            {
                string sql = @"INSERT INTO usuarios (nome, email, senha, matricula, tipo, periodo, curso) 
                               VALUES (@nome, @email, @senha, @matricula, @tipo, @periodo, @curso)";

                MySqlCommand cmdsql = new MySqlCommand(sql, Conn.conexao);

                cmdsql.Parameters.AddWithValue("@nome", obj.Nome);
                cmdsql.Parameters.AddWithValue("@email", obj.Email);
                cmdsql.Parameters.AddWithValue("@senha", obj.Senha);
                cmdsql.Parameters.AddWithValue("@matricula", obj.Matricula);
                cmdsql.Parameters.AddWithValue("@tipo", obj.Tipo);
                cmdsql.Parameters.AddWithValue("@periodo", obj.Periodo);
                cmdsql.Parameters.AddWithValue("@curso", obj.Curso);

                //Executar o comando pata inserir dados no banco
                cmdsql.ExecuteNonQuery();

                //Fechar a conexão
                Conn.conexao.Close();

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de cadastro entrar em contato com o Admin ", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        public void alterarUsuario(Usuario obj)
        {
            try
            {
                string sql = @"UPDATE usuarios set nome=@nome, email=@email, senha=@senha, matricula=@matricula, tipo=@tipo, periodo=@periodo, curso=@curso WHERE id = @id";
                               

                MySqlCommand cmdsql = new MySqlCommand(sql, Conn.conexao);

                cmdsql.Parameters.AddWithValue("@nome", obj.Nome);
                cmdsql.Parameters.AddWithValue("@email", obj.Email);
                cmdsql.Parameters.AddWithValue("@senha", obj.Senha);
                cmdsql.Parameters.AddWithValue("@matricula", obj.Matricula);
                cmdsql.Parameters.AddWithValue("@tipo", obj.Tipo);
                cmdsql.Parameters.AddWithValue("@periodo", obj.Periodo);
                cmdsql.Parameters.AddWithValue("@curso", obj.Curso);
                cmdsql.Parameters.AddWithValue("@id", obj.Id);

                //Executar o comando pata inserir dados no banco
                cmdsql.ExecuteNonQuery();

                //Fechar a conexão
                Conn.conexao.Close();

                MessageBox.Show("Alteração realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de alteração entrar em contato com o Admin ", "Erro de alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        public void excluirUsuario(Usuario obj)
        {
            try
            {
                string sql = @"DELETE FROM usuarios WHERE id = @id";


                MySqlCommand cmdsql = new MySqlCommand(sql, Conn.conexao);
                
                cmdsql.Parameters.AddWithValue("@id",obj.Id);


                //Executar o comando pata inserir dados no banco
                cmdsql.ExecuteNonQuery();

                //Fechar a conexão
                Conn.conexao.Close();

                MessageBox.Show("Exclusão realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de exclusão entrar em contato com o Admin ", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable listarUsuarios()
        {
            //Comando SQL
            string sql = @"SELECT * FROM usuarios";
            
            //Organizar o SQL
            MySqlCommand cmdsql = new MySqlCommand(sql, Conn.conexao);
           
            //Executar o comando
            cmdsql.ExecuteNonQuery();
            
            //Criar DataTable e MySQLDataAdapter
            DataTable tabelaUsuario = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmdsql);
            //Preencher o DataTable
            dataAdapter.Fill(tabelaUsuario);
            
            //Fechar a conexão
            Conn.conexao.Close();

            //Retornar tabela com os dados
            return tabelaUsuario;

           


        }

       
        public void login(string emailLogin, string senhaLogin)
        {

            ArrayList lst_contato = new ArrayList();

            try
            {
                string q = "'%" + emailLogin + "%'";
                

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
