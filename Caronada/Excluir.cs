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
            if (list_todos == 0 && RG.Text.Length != 10)
            {
                MessageBox.Show("RG incompleto!");
                return;
            }

            if (tipo == 1 && list_todos == 11) excluirUserTodos();
            else if (tipo == 1 && list_todos == 0) excluirUser(RG.Text);
            else if (tipo == 2 && list_todos == 1) excluirCaroneiroTodos();
            else if (tipo == 2 && list_todos == 0) excluirCaroneiro(RG.Text);
            else if (tipo == 3 && list_todos == 1) excluirCaronaTodos();
            else if (tipo == 3 && list_todos == 0) excluirCarona(RG.Text);
            else if (tipo == 4 && list_todos == 1) excluirComentarioTodos();
            else if (tipo == 4 && list_todos == 0) excluirComentario(nudCR.Value.ToString());
            else if (tipo == 5 && list_todos == 1) excluirRegiãoTodos();
            else if (tipo == 5 && list_todos == 0) excluirRegião(nudCR.Value.ToString());

            if (checkBox1.Checked) MessageBox.Show("Tabela excluída com Sucesso!!");
            else MessageBox.Show("Usuário '" + RG.Text + "' excluído com sucesso!!");

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
            if (radioButton1.Checked) tipo = 2;
            else { tipo = 0; }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) tipo = 1;
            else { tipo = 0; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) tipo = 3;
            else { tipo = 0; }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                tipo = 4;
                RG.Enabled = false;
                nudCR.Enabled = true;
            }
            else
            {
                tipo = 0;
                RG.Enabled = true;
                nudCR.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) tipo = 5;
            else { tipo = 0; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            list_todos = 1;
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
                    string query = "DELETE FROM USUARIO WHERE RG = '" + RG + "'";//WHERE RG = 1088351133";
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

        private void excluirCaroneiro(String RG)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(LoginADM.dbConString.ToString()))
                {
                    string query = "DELETE FROM CARONEIRO WHERE RG = '" + RG + "'";//WHERE RG = 1088351133";
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

        private void excluirCarona(String RG)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(LoginADM.dbConString.ToString()))
                {
                    string query = "DELETE FROM CARONA WHERE RG = '" + RG + "'";//WHERE RG = 1088351133";
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

        private void excluirComentario(String n_coment)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(LoginADM.dbConString.ToString()))
                {
                    string query = "DELETE FROM USUARIO WHERE N_COMENTARIO = " + n_coment;
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

        private void excluirRegiãoTodos()
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
        
        private void excluirRegião(String ID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(LoginADM.dbConString.ToString()))
                {
                    string query = "DELETE FROM REGIAO WHERE ID = " + ID;

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
