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
            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    listView1.Items.Clear();
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
                
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
            conn.Close();
            reader.Close();
        }

        public void procuraUserTodos()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM USUARIO ";
            string[] lista = new string[7];
            listView2.Hide();
            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                listView1.Items.Clear();
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
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
            conn.Close();
            reader.Close();
        }

        public void procuraCaroneiro(String RG)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM CARONEIRO WHERE RG = " + "" + RG + "";
            string[] lista = new string[7];
            listView1.Hide();
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
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
            conn.Close();
            reader.Close();
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
                listView1.Clear();

                while (reader.Read())
                {
                    lista[0] = reader["RG"].ToString();
                    lista[1] = reader["TIPO_VEICULO"].ToString();
                    lista[2] = reader["PLACA"].ToString();
                    lista[3] = reader["MAX_CARONAS"].ToString();
                

                    ListViewItem lvi = new ListViewItem(lista);
                    listView2.Items.Add(lvi);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
            conn.Close();
            reader.Close();
        }

        public void procuraCarona(String RG)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM CARONA WHERE RG = " + "" + RG + "";

            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //reader["RG"].ToString();
                    //procura funcionanod, nao consegui add no listview
                    MessageBox.Show(reader["RG"].ToString());
                    MessageBox.Show(reader["PESO"].ToString());
                    MessageBox.Show(reader["ALTURA"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
            conn.Close();
            reader.Close();
        }

        public void procuraCaronaTodos()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM CARONA ";
            string[] lista = new string[7];

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
                    listView1.Items.Add(lvi);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
            conn.Close();
            reader.Close();
        }
        
        public void procuraComentario(String RG)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM COMENTARIO WHERE RG = " + "" + RG + "";
            string[] lista = new string[7];

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
                    listView1.Items.Add(lvi);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
            conn.Close();
            reader.Close();
        }

        public void procuraComentarioTodos()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM COMENTARIO ";
            string[] lista = new string[7];

            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                listView1.Clear();

                while (reader.Read())
                {
                    lista[0] = reader["RG"].ToString();
                    lista[1] = reader["PESO"].ToString();
                    lista[2] = reader["ALTURA"].ToString();

                    ListViewItem lvi = new ListViewItem(lista);
                    listView1.Items.Add(lvi);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
            conn.Close();
            reader.Close();
        }

        public void procuraGrupo(String RG)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM GRUPO WHERE RG = " + "" + RG + "";
            string[] lista = new string[7];

            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                listView1.Clear();
                if (reader.Read())
                {
                    lista[0] = reader["RG"].ToString();
                    lista[1] = reader["PESO"].ToString();
                    lista[2] = reader["ALTURA"].ToString();

                    ListViewItem lvi = new ListViewItem(lista);
                    listView1.Items.Add(lvi);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
            conn.Close();
            reader.Close();
        }
        
        public void procuraGrupoTodos()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM GRUPO ";

            try
            {
                conn = new SqlConnection(LoginADM.dbConString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                listView1.Clear();
                while (reader.Read())
                {
                    //lista[0] = reader["RG"].ToString();

                    //ListViewItem lvi = new ListViewItem(lista);
                    //listView1.Items.Add(lvi);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
            conn.Close();
            reader.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
