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
    public partial class Inserir : Form
    {
        public Inserir()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Inserir_Load(object sender, EventArgs e)
        {
        }

        private void Caroneiro_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Show();
            N_COMENTARIO.Show(); 
            RG.Show();
            monthCalendar1.Show();
            textBox3.Show();

            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Hide();

            radioButton1.Hide();
            radioButton2.Hide();
            textBox8.Hide();
            textBox7.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
        }

        private void Grupo_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Show();
            radioButton2.Show();

            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Show();
            label11.Hide();
            label12.Hide();

            textBox2.Hide();
            N_COMENTARIO.Hide();
            monthCalendar1.Hide();
            textBox3.Hide();
            textBox6.Hide();
            textBox5.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,"Cadastrado com Sucesso!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opções op = new Opções();
            this.Hide();
            op.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Show();
            textBox7.Show();
            textBox4.Show();

            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();

            label11.Hide();
            label12.Hide();

            textBox5.Hide();
            textBox6.Hide();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox5.Show();
            textBox6.Show();

            label11.Show();
            label12.Show();

            textBox7.Hide();
            textBox4.Hide();
            textBox8.Hide();

            label10.Hide();
            label7.Hide();
            label9.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
