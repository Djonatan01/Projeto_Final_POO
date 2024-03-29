﻿using AgendaProvas.Model;
using AgendaProvas.View;
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
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgendaProvas.Dao
{
    public class UsuarioDao
    {
        public string check;
        #region Método conectar Banco de dados
        public UsuarioDao() 
        {
            //Abrir conexão com o banco de dados
            Conn.conectar();
        }
        #endregion

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

                MessageBox.Show("Cadastro realizado com sucesso!","Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Matricula já cadastrada " , "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Método de alteração
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

                MessageBox.Show("Alteração realizada com sucesso!","Alteração",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de alteração entrar em contato com o Admin ", "Erro de alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        #endregion

        #region Método de excluir
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

                MessageBox.Show("Exclusão realizada com sucesso!","Exclusão",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de exclusão entrar em contato com o Admin ", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Método listar usuarios 
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

        #endregion

        #region Método listar usuarios nome
        public DataTable listarUsuariosNome(String nome)
        {
            //Comando SQL
            string q = "'" + nome + "%" + "'";
            //Comando SQL
            string sql = @"SELECT* FROM usuarios WHERE nome like " + q;

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

        #endregion

        #region Método login
        public String login(string emailLogin, string senhaLogin)
        {
            
            ArrayList lst_contato = new ArrayList();

            try
            {
                string q = "'" + emailLogin + "'";
                string q1 = "'" + senhaLogin + "'";

                string sql = "SELECT* FROM `usuarios` WHERE `email` = "+ q+" AND `senha`="+q1;

                MySqlCommand comnadoConsulta = new MySqlCommand(sql, Conn.conexao);

                MySqlDataReader reader = comnadoConsulta.ExecuteReader();

                if (reader.HasRows) {
                    reader.Read();
                    string tipo = reader.GetString(5);
                    if (tipo.Equals("Professor")) 
                    {
                        check = "3"; 
                    }else if(tipo.Equals("admin"))
                    {
                        check = "0";
                    }
                    else
                    {
                        check = "1/" + reader.GetString(7);
                    }
                }
                else
                {
                    check = "4";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de cadastro entrar em contato com o Admin ", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return check;
        }
        #endregion
    }
}
