using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (tipo == 1 && list_todos == 11) excluirUserTodos();
            if (tipo == 1 && list_todos == 0) excluirUser(RG.ToString());
            if (tipo == 2 && list_todos == 11) excluirCaroneiroTodos();
            if (tipo == 3 && list_todos == 11) excluirCaronaTodos();
            if (tipo == 4 && list_todos == 11) excluirComentarioTodos();
            if (tipo == 5 && list_todos == 11) excluirGrupoTodos();
            if ((radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked) && !(checkBox1.Checked) && RG.TextLength == 10 ) MessageBox.Show("Usuário '" + RG.Text + "' excluído com sucesso!!");
            if(checkBox1.Checked)MessageBox.Show("Tabela excluída com Sucesso!!");

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
            if (radioButton3.Checked) tipo = 2;
            else { tipo = 0; }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) tipo = 1;
            else { tipo = 0; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) tipo = 3;
            else { tipo = 0; }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) tipo = 4;
            else { tipo = 0; }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) tipo = 5;
            else { tipo = 0; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            list_todos = 11;
            if (checkBox1.Checked)
            {
                RG.Enabled = false;
            }
            else
            {
                RG.Enabled = true;
                list_todos = 0;
            }
        }

        private void excluirUser(String RG)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(LoginADM.dbConString.ToString()))
                {
                    string query = "";
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void excluirUserTodos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(LoginADM.dbConString.ToString()))
                {
                    string query = "DELETE USUARIO ";//WHERE RG = 1088351133";
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                         command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
               MessageBox.Show(""+ex.Message);
            }
            
        }

        private void excluirCaroneiroTodos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(LoginADM.dbConString.ToString()))
                {
                    string query = "DELETE FROM CARONEIRO ";//WHERE RG = 1088351133";
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void excluirCaronaTodos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(LoginADM.dbConString.ToString()))
                {
                    string query = "DELETE FROM CARONA ";//WHERE RG = 1088351133";
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void excluirComentarioTodos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(LoginADM.dbConString.ToString()))
                {
                    string query = "DELETE FROM COMENTARIO ";//WHERE RG = 1088351133";
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void excluirGrupoTodos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(LoginADM.dbConString.ToString()))
                {
                    string query = "DELETE FROM REGIAO ";//WHERE RG = 1088351133";
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }
    }
}   
