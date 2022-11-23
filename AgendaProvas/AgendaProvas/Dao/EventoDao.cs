using AgendaProvas.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProvas.Dao
{
    public class EventoDao
    {
        public EventoDao() 
        {
            //Abrir conexão com o banco de dados
            Conn.conectar();
        }

        #region Método cadastrar evento
        public void cadastrarEvento(Evento obj)
        {
            try
            {
                string sql = @"INSERT INTO eventos (data, hora, disciplina, periodo, curso,sala) 
                               VALUES (@data, @hora, @disciplina, @periodo, @curso,@sala)";

                MySqlCommand cmdsql = new MySqlCommand(sql, Conn.conexao);

                cmdsql.Parameters.AddWithValue("@data", obj.Data);
                cmdsql.Parameters.AddWithValue("@hora", obj.Hora);
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
                MessageBox.Show("Erro de cadastro entrar em contato com o Admin ", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
