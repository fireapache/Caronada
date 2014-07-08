using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Caronada
{
    public partial class Excluir : Form
    {
        int tipo = 0;
        int list_todos = 0;
        public Excluir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipo == 1 && list_todos == 0)
            {
                excluirUser(RG.ToString());
            }

        }

        private void Excluir_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginADM.showOpções();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
            //caroneiro
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 1;
            //usuario
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 3;
            //carona
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 4;
            //comentario
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 5;
            //grupo
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 1;
            //checkbox
        }

        private void excluirUser(string RG)
        {
            try
            {
                SqlConnection conn = null;
                conn = new SqlConnection(LoginADM.dbConString);
                SqlCommand comm = new SqlCommand();
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = "DELETE FROM USUARIO WHERE RG ";
                //comm.Parameters.AddWithValue("@RG", 1);
                comm.Connection = conn;

                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Usuario excluído com sucesso!!");
            }
            catch(Exception e)
            {
                MessageBox.Show(""+e);
            }
        }
    }
}
