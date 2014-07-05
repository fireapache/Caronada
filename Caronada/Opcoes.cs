using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caronada
{
    public partial class Opcoes : Form
    {
        public Opcoes()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            this.Hide();
            cadastro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Procurar procurar = new Procurar();
            this.Hide();
            procurar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            this.Hide();
            inserir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Excluir excluir = new Excluir();
            this.Hide();
            excluir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }
    }
}
