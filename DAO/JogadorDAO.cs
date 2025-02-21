using joagadoresTimes.Data;
using joagadoresTimes.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joagadoresTimes.DAO
{
    class JogadorDAO
    {
        public void InsertJogadores(Jogadores jogadores)
        {
            try
            {
                string sql = "INSERT INTO jogadores (nome, dt_nascimento, sexo, cpf, rg, email, peso," +
                    " altura, telefone, nacionalidade, apelido, posicao, n_camisa, foto, time_anterior," +
                    " data_hora_inicio, data_hora_fim) VALUES(@nome, @dt_nascimento, @sexo, @cpf, @rg, @email," +
                    " @peso, @altura, @telefone, @nacionalidade, @apelido, @posicao, @n_camisa, @foto, @time_anterior, " +
                    " @data_hora_inicio, @data_hora_fim)";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", jogadores.nome);
                comando.Parameters.AddWithValue("@dt_nascimento", jogadores.dt_nascimento);
                comando.Parameters.AddWithValue("@sexo", jogadores.sexo);
                comando.Parameters.AddWithValue("@cpf", jogadores.cpf);
                comando.Parameters.AddWithValue("@rg", jogadores.rg);
                comando.Parameters.AddWithValue("@email", jogadores.email);
                comando.Parameters.AddWithValue("@peso", jogadores.peso);
                comando.Parameters.AddWithValue("@altura", jogadores.altura);
                comando.Parameters.AddWithValue("@telefone", jogadores.telefone);
                comando.Parameters.AddWithValue("@nacionalidade", jogadores.nacionalidade);
                comando.Parameters.AddWithValue("@apelido", jogadores.apelido);
                comando.Parameters.AddWithValue("@posicao", jogadores.posicao);
                comando.Parameters.AddWithValue("@n_camisa", jogadores.n_camisa);
                comando.Parameters.AddWithValue("@time_anterior", jogadores.time_anterior);
                comando.Parameters.AddWithValue("@data_hora_inicio", jogadores.data_hora_inicio);
                comando.Parameters.AddWithValue("@data_hora_fim", jogadores.data_hora_fim);

                comando.ExecuteNonQuery();

                MessageBox.Show("Jogador cadastrado com sucesso!");

                Conexao.FecharConexao();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o jogador!" + ex.Message);
            }
        }

    }
}
