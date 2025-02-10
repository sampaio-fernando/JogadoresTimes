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
        private void btCadJogadores_Click(object sender, EventArgs e)
        {
            CadJogador form = new CadJogador(); 
            form.ShowDialog();
        }
    }
}
