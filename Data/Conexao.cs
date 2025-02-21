using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joagadoresTimes.Data
{
    internal static class Conexao
    {
        static MySqlConnection _conexao; 
        static string strconexao = "server=localhost;Port=3306;uid=root;pwd=root;database=timeFutebol";

        public static MySqlConnection Conectar()
        {
            try
            {
                _conexao = new MySqlConnection(strconexao); //conectando a aplicação com o banco de dados
                _conexao.Open();
            }
            catch(Exception ex)
            {
               throw new Exception ("Erro ao conectar" + ex);
            }

            return _conexao;
        }

        public static void FecharConexao()
        {
            _conexao.Close();
        }
    }
}
