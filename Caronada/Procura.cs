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
using System.Data.Sql;
namespace Caronada
{
    public partial class Procura : Form
    {
        public Procura()
        {
            InitializeComponent();
        }

        private void Procura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginADM.showProcurar();
        }

        public void procuraUser(String RG)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM USUARIO WHERE RG = " + "" + RG + "";
            string[] lista = new string[7];
            listView2.Hide();
            listView3.Hide();
            listView4.Hide();
            listView5.Hide();
            listView1.Show();
            listView1.Items.Clear();

            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lista[0] = reader["RG"].ToString();
                    lista[1] = reader["NOME"].ToString();
                    lista[2] = reader["DATA_NASC"].ToString();
                    lista[3] = reader["HORA_IDA"].ToString();
                    lista[4] = reader["HORA_VOLTA"].ToString();
                    lista[5] = reader["CONTATO"].ToString();
                    lista[6] = reader["REGIAO"].ToString();

                    ListViewItem lvi = new ListViewItem(lista);
                    listView1.Items.Add(lvi);
                }

                conn.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
        }

        public void procuraUserTodos()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM USUARIO ";
            string[] lista = new string[7];
            listView2.Hide();
            listView3.Hide();
            listView4.Hide();
            listView5.Hide();
            listView1.Show();
            listView1.Items.Clear();

            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista[0] = reader["RG"].ToString();
                    lista[1] = reader["NOME"].ToString();
                    lista[2] = reader["DATA_NASC"].ToString();
                    lista[3] = reader["HORA_IDA"].ToString();
                    lista[4] = reader["HORA_VOLTA"].ToString();
                    lista[5] = reader["CONTATO"].ToString();
                    lista[6] = reader["REGIAO"].ToString();

                    ListViewItem lvi = new ListViewItem(lista);
                    listView1.Items.Add(lvi);
                }
                conn.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
        }

        public void procuraCaroneiro(String RG)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM CARONEIRO WHERE RG = " + "" + RG + "";
            string[] lista = new string[7];
            listView1.Hide();
            listView3.Hide();
            listView4.Hide();
            listView5.Hide();
            listView2.Show();
            listView2.Items.Clear();

            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lista[0] = reader["RG"].ToString();
                    lista[1] = reader["TIPO"].ToString();
                    lista[2] = reader["PLACA"].ToString();
                    lista[3] = reader["CARONAS"].ToString();

                    ListViewItem lvi = new ListViewItem(lista);
                    listView2.Items.Add(lvi);

                    conn.Close();
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
        }

        public void procuraCaroneiroTodos()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM CARONEIRO ";
            string[] lista = new string[7];

            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                listView1.Hide();
                listView3.Hide();
                listView4.Hide();
                listView5.Hide();
                listView2.Items.Clear();
                listView2.Show();
                
                while (reader.Read())
                {
                    lista[0] = reader["RG"].ToString();
                    lista[1] = reader["TIPO_VEICULO"].ToString();
                    lista[2] = reader["PLACA"].ToString();
                    lista[3] = reader["MAX_CARONAS"].ToString();
                

                    ListViewItem lvi = new ListViewItem(lista);
                    listView2.Items.Add(lvi);

                    
                }
                conn.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
        }

        public void procuraCarona(String RG)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM CARONA WHERE RG = " + "" + RG + "";
            string[] lista = new string[7];

            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                listView3.Items.Clear();
                listView1.Hide();
                listView2.Hide();
                listView4.Hide();
                listView5.Hide();
                listView3.Show();
                
                if (reader.Read())
                {
                    lista[0] = reader["RG"].ToString();
                    lista[1] = reader["PESO"].ToString();
                    lista[2] = reader["ALTURA"].ToString();

                    ListViewItem lvi = new ListViewItem(lista);
                    listView3.Items.Add(lvi);
                }

                conn.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
        }

        public void procuraCaronaTodos()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM CARONA ";
            string[] lista = new string[7];
            listView1.Hide();
            listView2.Hide();
            listView4.Hide();
            listView5.Hide();
            listView3.Items.Clear();
            listView3.Show();
            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista[0] = reader["RG"].ToString();
                    lista[1] = reader["PESO"].ToString();
                    lista[2] = reader["ALTURA"].ToString();

                    ListViewItem lvi = new ListViewItem(lista);
                    listView3.Items.Add(lvi);
                }

                conn.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
        }
        
        public void procuraComentario(String RG)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM COMENTARIO WHERE RG = " + "" + RG + "";
            string[] lista = new string[7];
            listView1.Hide();
            listView2.Hide();
            listView3.Hide();
            listView5.Hide();
            listView4.Items.Clear();
            listView4.Show();
            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lista[0] = reader["RG"].ToString();
                    lista[1] = reader["N_COMENTARIO"].ToString();
                    lista[2] = reader["COMENTARIO"].ToString();

                    ListViewItem lvi = new ListViewItem(lista);
                    listView4.Items.Add(lvi);
                }

                conn.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
        }

        public void procuraComentarioTodos()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM COMENTARIO ";
            string[] lista = new string[7];
            listView1.Hide();
            listView2.Hide();
            listView3.Hide();
            listView5.Hide();
            listView4.Items.Clear();
            listView4.Show();
            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista[0] = reader["RG"].ToString();
                    lista[1] = reader["PESO"].ToString();
                    lista[2] = reader["ALTURA"].ToString();

                    ListViewItem lvi = new ListViewItem(lista);
                    listView4.Items.Add(lvi);
                }

                conn.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
        }

        public void procuraGrupo(String RG)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM GRUPO WHERE RG = " + "" + RG + "";
            string[] lista = new string[7];
            listView1.Hide();
            listView2.Hide();
            listView3.Hide();
            listView4.Hide();
            listView5.Items.Clear();
            listView5.Show();
            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    //ListViewItem lvi = new ListViewItem(lista);
                    //listView5.Items.Add(lvi);
                }

                conn.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
        }
        
        public void procuraGrupoTodos()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM GRUPO ";
            listView1.Hide();
            listView2.Hide();
            listView3.Hide();
            listView4.Hide();
            listView5.Items.Clear();
            listView5.Show();
            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //lista[0] = reader["RG"].ToString();

                    //ListViewItem lvi = new ListViewItem(lista);
                    //listView5.Items.Add(lvi);
                }

                conn.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
