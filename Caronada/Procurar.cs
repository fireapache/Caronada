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
    public partial class Procurar : Form
    {
        public Procurar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Aqui vai os dados procurados na tabela!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Opcoes op = new Opcoes();
            this.Hide();
            op.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
