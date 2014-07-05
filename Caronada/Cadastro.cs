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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        int i=1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "NOME")
            {
                progressBar1.Value = i;
                i = i + 1;
            }
        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Web_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Caroneiro_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Maximum = 7;
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();

            label5.Show();
            label6.Show();
            label7.Show();

            label8.Hide();
            label9.Hide();
        }

        private void Carona_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Maximum = 6;
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Show();
            textBox6.Show();
            label8.Show();
            label9.Show();

            label5.Hide();
            label6.Hide();
            label7.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Maximum = 4;
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();

            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Cadastrado com Sucesso!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opcoes op = new Opcoes();
            this.Hide();
            op.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RG_TextChanged(object sender, EventArgs e)
        {
            //if(e.Enter == Keys.Enter)//Não ta pegando o enter
            //{
                //progressBar1.Value = i;
                //i = i + 1;
            //}
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text != "9999999999999999999")
            {
                progressBar1.Value = i;
                i = i + 1;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (RG.Text != "PESO?")
            {
                progressBar1.Value = i;
                i = i + 1;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (RG.Text != "ALTURA?")
            {
                progressBar1.Value = i;
                i = i + 1;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (RG.Text != "MAX_CARONAS")
            {
                progressBar1.Value = i;
                i = i + 1;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
