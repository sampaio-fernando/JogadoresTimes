using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using joagadoresTimes;

namespace joagadoresTimes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Times
        {
            public int id_time;
            public string nome_oficial;
            public string nome_fantasia;
            public string endereco;
            public DateTime dt_fundacao;
            public string escudo;
            public string telefone;
            public string email;
            public string estadio;
        }

        public class Jogadores
        {
            public int id_jogador;
            public string nome;
            public DateTime dt_nascimento;
            public string sexo;
            public string cpf;
            public string rg;
            public string email;
            public double peso;
            public double altura;
            public string telefone;
            public string endereco;
            public string nacionalidade;
            public string apelido;
            public string posicao;
            public int n_camisa;
            public string foto;
            public string time_anterior;
            public DateTime data_hora_inicio;
            public DateTime data_hora_fim;
            public Times times;
        }


        private void btCadJogadores_Click(object sender, EventArgs e)
        {
            CadJogador form = new CadJogador(); 
            form.ShowDialog();
        }
    }
}
