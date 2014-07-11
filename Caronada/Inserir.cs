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
    public partial class Inserir : Form
    {
        public Inserir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbComentario.Checked)
            {
                inserirComentário();
            }
            else if (rbGrupo.Checked)
            {
                inserirRegião();
            }
        }

        private void inserirComentário()
        {
            if (tbRG.Text.Length != 10)
            {
                MessageBox.Show("RG incompleto!");
                return;
            }

            if (tbComentário.Text.Length == 0)
            {
                MessageBox.Show("Adicionar comentário!");
                return;
            }

            String command;
            String RG, comentário, nComentário;
            Random random = new Random();

            RG = tbRG.Text;
            comentário = tbComentário.Text;
            nComentário = random.Next(1000000).ToString();

            command = "INSERT INTO COMENTARIO (RG, N_COMENTARIO, COMENTARIO, DATA) VALUES (";
            command += "'" + RG + "', ";
            command += nComentário + ", ";
            command += "'" + comentário + "', ";
            command += "'20140709')";

            SqlConnection sqlConnection = new SqlConnection(LoginADM.dbConString);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Comentário inserido com sucesso! \n\n Nº = " + nComentário.ToString());
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void inserirRegião()
        {
            if (tbBairro.Text.Length == 0)
            {
                MessageBox.Show("Adicionar Bairro!");
                return;
            }

            String command;
            String ID, bairro, referência;

            ID = nudRegiãoID.Value.ToString();
            bairro = tbBairro.Text;
            referência = tbReferência.Text;

            command = "INSERT INTO REGIAO (ID, BAIRRO, REFERENCIA) VALUES (";
            command += ID + ", ";
            command += "'" + bairro + "', ";
            command += "'" + referência + "')";

            SqlConnection sqlConnection = new SqlConnection(LoginADM.dbConString);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Região inserida com sucesso!");
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginADM.showOpções();
        }

        private void Região_CheckedChanged(object sender, EventArgs e)
        {
            lbRG.Hide();
            tbRG.Hide();
            lbComentário.Hide();
            tbComentário.Hide();

            lbRegiãoID.Show();
            nudRegiãoID.Show();
            lbBairro.Show();
            tbBairro.Show();
            lbReferência.Show();
            tbReferência.Show();
        }

        private void Comentario_CheckedChanged(object sender, EventArgs e)
        {
            lbRG.Show();
            tbRG.Show();
            lbComentário.Show();
            tbComentário.Show();

            lbRegiãoID.Hide();
            nudRegiãoID.Hide();
            lbBairro.Hide();
            tbBairro.Hide();
            lbReferência.Hide();
            tbReferência.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inserir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
