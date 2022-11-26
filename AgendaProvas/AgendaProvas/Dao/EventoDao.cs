using AgendaProvas.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProvas.Dao
{
    public class EventoDao
    {

        #region Método Conectr Banco de Dados
        public EventoDao() 
        {
            //Abrir conexão com o banco de dados
            Conn.conectar();
        }
        #endregion

        #region Método cadastrar evento
        public void cadastrarEvento(Evento obj)
        {
            try
            {
                string sql = @"INSERT INTO eventos (data, hora,evento, disciplina, periodo, curso,sala) 
                               VALUES (@data, @hora,@evento, @disciplina, @periodo, @curso, @sala)";

                MySqlCommand cmdsql = new MySqlCommand(sql, Conn.conexao);

                cmdsql.Parameters.AddWithValue("@data", obj.Data);
                cmdsql.Parameters.AddWithValue("@hora", obj.Hora);
                cmdsql.Parameters.AddWithValue("@evento", obj.Eventos);
                cmdsql.Parameters.AddWithValue("@disciplina", obj.Disciplina);
                cmdsql.Parameters.AddWithValue("@periodo", obj.Periodo);
                cmdsql.Parameters.AddWithValue("@curso", obj.Curso);
                cmdsql.Parameters.AddWithValue("@sala", obj.Sala);

                //Executar o comando pata inserir dados no banco
                cmdsql.ExecuteNonQuery();

                //Fechar a conexão
                Conn.conexao.Close();

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de cadastro entrar em contato com o Admin " + ex, "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Método alterar evento
        public void alterarEvento(Evento obj)
        {
            try
            {
                string sql = @"UPDATE eventos set data=@data, hora=@hora, evento=@evento , disciplina=@disciplina, periodo=@periodo, curso=@curso, sala=@sala WHERE id = @id";


                MySqlCommand cmdsql = new MySqlCommand(sql, Conn.conexao);

                cmdsql.Parameters.AddWithValue("@data", obj.Data);
                cmdsql.Parameters.AddWithValue("@hora", obj.Hora);
                cmdsql.Parameters.AddWithValue("@evento", obj.Eventos);
                cmdsql.Parameters.AddWithValue("@disciplina", obj.Disciplina);
                cmdsql.Parameters.AddWithValue("@periodo", obj.Periodo);
                cmdsql.Parameters.AddWithValue("@curso", obj.Curso);
                cmdsql.Parameters.AddWithValue("@sala", obj.Sala);
                cmdsql.Parameters.AddWithValue("@id", Convert.ToInt32(obj.Id));


                //Executar o comando pata inserir dados no banco
                cmdsql.ExecuteNonQuery();

                //Fechar a conexão
                Conn.conexao.Close();

                MessageBox.Show("Alteração realizada com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de alteração entrar em contato com o Admin " + ex, "Erro de alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Método de excluir
        public void excluirEvento(Evento obj)
        {
            try
            {
                string sql = @"DELETE FROM eventos WHERE id = @id";


                MySqlCommand cmdsql = new MySqlCommand(sql, Conn.conexao);

                cmdsql.Parameters.AddWithValue("@id", obj.Id);


                //Executar o comando pata inserir dados no banco
                cmdsql.ExecuteNonQuery();

                //Fechar a conexão
                Conn.conexao.Close();

                MessageBox.Show("Exclusão realizada com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de exclusão entrar em contato com o Admin ", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Método listar eventos 
        public DataTable listarEventos()
        {
            //Comando SQL
            string sql = @"SELECT * FROM eventos";

            //Organizar o SQL
            MySqlCommand cmdsql = new MySqlCommand(sql, Conn.conexao);

            //Executar o comando
            cmdsql.ExecuteNonQuery();

            //Criar DataTable e MySQLDataAdapter
            DataTable tabelaEvento = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmdsql);
            //Preencher o DataTable
            dataAdapter.Fill(tabelaEvento);

            //Fechar a conexão
            Conn.conexao.Close();

            //Retornar tabela com os dados
            return tabelaEvento;
        }

        #endregion

        #region Método listar eventos por Disciplina 
        public DataTable listarEventosPorDisciplina(String data)
        {

            string q = "'" + data + "%" + "'";
            //Comando SQL
            string sql = @"SELECT* FROM eventos WHERE data like " + q;

            //Organizar o SQL
            MySqlCommand cmdsql = new MySqlCommand(sql, Conn.conexao);

            //Executar o comando
            cmdsql.ExecuteNonQuery();

            //Criar DataTable e MySQLDataAdapter
            DataTable tabelaEvento = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmdsql);
            //Preencher o DataTable
            dataAdapter.Fill(tabelaEvento);

            //Fechar a conexão
            Conn.conexao.Close();

            //Retornar tabela com os dados
            return tabelaEvento;
        }

        #endregion

        #region Método listar eventos por Curso 
        public DataTable listarEventosPorCurso(String buscaCurso)
        {
            string curso = buscaCurso.ToUpper();

            string q = "'" + curso + "'";
            //Comando SQL
            string sql = @"SELECT* FROM eventos WHERE curso = " + q;

            //Organizar o SQL
            MySqlCommand cmdsql = new MySqlCommand(sql, Conn.conexao);

            //Executar o comando
            cmdsql.ExecuteNonQuery();

            //Criar DataTable e MySQLDataAdapter
            DataTable tabelaEvento = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmdsql);
            //Preencher o DataTable
            dataAdapter.Fill(tabelaEvento);

            //Fechar a conexão
            Conn.conexao.Close();

            //Retornar tabela com os dados
            return tabelaEvento;
        }

        #endregion

        #region Método listar eventos por Data e Curso
        public DataTable listarEventosPorDataCurso(String data, String newCurso)
        {
            
            string curso = newCurso.ToUpper();            
            string q = "'" + data + "%" + "'";
            string q2 = "'" + curso + "'";
            //Comando SQL
            string sql = @"SELECT* FROM eventos WHERE data like " + q + "AND curso =" + q2 ;

            //Organizar o SQL
            MySqlCommand cmdsql = new MySqlCommand(sql, Conn.conexao);

            //Executar o comando
            cmdsql.ExecuteNonQuery();

            //Criar DataTable e MySQLDataAdapter
            DataTable tabelaEvento = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmdsql);
            //Preencher o DataTable
            dataAdapter.Fill(tabelaEvento);

            //Fechar a conexão
            Conn.conexao.Close();

            //Retornar tabela com os dados
            return tabelaEvento;
        }

        #endregion
    }
}
