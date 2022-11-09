using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaProvas.Dao;
using MySql.Data.MySqlClient;

namespace AgendaProvas
{
    public class Consulta
    {
        public void consultar(string emailLogin,string senhaLogin)
        {
            //Abrir conexão com o banco de dados
            Conn.conectar();
            try
            {
                string sql = "SELELCT * FROM usuarios";

                MySqlCommand comnadoConsulta = new MySqlCommand(sql, Conn.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = comnadoConsulta;

                DataTable dt = new DataTable();

                da.Fill(dt);

                            }
            catch(Exception e)
            {
                MessageBox.Show("Erro de cadastro entrar em contato com o Admin ", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
