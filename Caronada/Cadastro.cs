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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void rdCaroneiro_CheckedChanged(object sender, EventArgs e)
        {
            tbVeículo.Show();
            tbPlaca.Show();
            nudCaronas.Show();

            nudPeso.Hide();
            nudAltura.Hide();

            lbVeículo.Show();
            lbPlaca.Show();
            lbCaronas.Show();

            lbPeso.Hide();
            lbAltura.Hide();

            lbUsuárioRG.Show();
            tbUsuárioRG.Show();

            tbRG.Enabled = false;
            tbNome.Enabled = false;
            dateNascimento.Enabled = false;
            timeHoraIda.Enabled = false;
            timeHoraVolta.Enabled = false;
            nudRegião.Enabled = false;
            tbContato.Enabled = false;
        }

        private void rdCarona_CheckedChanged(object sender, EventArgs e)
        {
            tbVeículo.Hide();
            tbPlaca.Hide();
            nudCaronas.Hide();

            nudPeso.Show();
            nudAltura.Show();

            lbPeso.Show();
            lbAltura.Show();

            lbVeículo.Hide();
            lbPlaca.Hide();
            lbCaronas.Hide();

            lbUsuárioRG.Show();
            tbUsuárioRG.Show();

            tbRG.Enabled = false;
            tbNome.Enabled = false;
            dateNascimento.Enabled = false;
            timeHoraIda.Enabled = false;
            timeHoraVolta.Enabled = false;
            nudRegião.Enabled = false;
            tbContato.Enabled = false;
        }

        private void rdUsuário_CheckedChanged(object sender, EventArgs e)
        {
            tbVeículo.Hide();
            tbPlaca.Hide();
            nudCaronas.Hide();
            nudPeso.Hide();
            nudAltura.Hide();

            lbVeículo.Hide();
            lbPlaca.Hide();
            lbCaronas.Hide();
            lbPeso.Hide();
            lbAltura.Hide();

            lbUsuárioRG.Hide();
            tbUsuárioRG.Hide();

            tbRG.Enabled = true;
            tbNome.Enabled = true;
            dateNascimento.Enabled = true;
            timeHoraIda.Enabled = true;
            timeHoraVolta.Enabled = true;
            nudRegião.Enabled = true;
            tbContato.Enabled = true;
        }

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LoginADM.showOpções();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (rdUsuário.Checked) cadastrarUsuário();
            else if (rdCarona.Checked) cadastrarCarona();
            else cadastrarCaroneiro();
        }

        private bool formulárioUsuárioPreenchido()
        {
            bool preenchido = true;

            if (tbRG.Text.Length < 10)
            {
                MessageBox.Show("RG precisa ter 10 caracteres!");
                preenchido = false;
            }

            if (tbNome.Text.Length == 0)
            {
                MessageBox.Show("O usuário precisa de nome!");
                preenchido = false;
            }

            if (tbContato.Text.Length < 8)
            {
                MessageBox.Show("O usuário precisa de contato (8 ou + caracteres)!");
                preenchido = false;
            }

            return preenchido;
        }

        private void cadastrarUsuário()
        {
            if (!formulárioUsuárioPreenchido())
            {
                MessageBox.Show("Erro ao cadastrar usuário!");
                return;
            }

            String command;
            String RG, nome, dataNasc, hora_ida, hora_volta, contato, região;
            String ano, mês, dia;

            RG = tbRG.Text;
            nome = tbNome.Text;

            ano = dateNascimento.Value.Year.ToString();
            mês = dateNascimento.Value.Month.ToString();
            dia = dateNascimento.Value.Day.ToString();

            if (mês.Length == 1) mês = mês.Insert(0, "0");
            if (dia.Length == 1) dia = dia.Insert(0, "0");

            dataNasc = ano + mês + dia;

            hora_ida = timeHoraIda.Value.ToShortTimeString();
            hora_volta = timeHoraVolta.Value.ToShortTimeString();
            contato = tbContato.Text;
            região = nudRegião.Value.ToString();

            command = "INSERT INTO USUARIO (RG, NOME, DATA_NASC, HORA_IDA, HORA_VOLTA, CONTATO, REGIAO) VALUES (";
            command += "'" + RG + "', ";
            command += "'" + nome + "', ";
            command += "'" + dataNasc + "', ";
            command += "'" + hora_ida + "', ";
            command += "'" + hora_volta + "', ";
            command += "'" + contato + "', ";
            command += região + ")";

            SqlConnection sqlConnection = new SqlConnection(LoginADM.dbConString);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso!");
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private bool formulárioCaronaPreenchido()
        {
            bool preenchido = true;

            if (tbUsuárioRG.Text.Length < 10)
            {
                MessageBox.Show("RG de usuário incompleto!");
                preenchido = false;
            }

            return preenchido;
        }

        private void cadastrarCarona()
        {
            if (!formulárioCaronaPreenchido())
            {
                MessageBox.Show("Erro ao cadastrar carona!");
                return;
            }

            String command;
            String RG, peso, altura;

            RG = tbUsuárioRG.Text;
            peso = nudPeso.Value.ToString();
            altura = nudAltura.Value.ToString();

            command = "INSERT INTO CARONA (RG, PESO, ALTURA) VALUES (";
            command += "'" + RG + "', ";
            command += peso + ", ";
            command += altura + ")";

            SqlConnection sqlConnection = new SqlConnection(LoginADM.dbConString);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Carona cadastrado com sucesso!");
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private bool formulárioCaroneiroPreenchido()
        {
            bool preenchido = true;

            if (tbUsuárioRG.Text.Length < 10)
            {
                MessageBox.Show("RG de usuário incompleto!");
                preenchido = false;
            }

            if (tbPlaca.Text.Length < 8)
            {
                MessageBox.Show("Placa do carro não especificada!");
                preenchido = false;
            }

            return preenchido;
        }

        private void cadastrarCaroneiro()
        {
            if (!formulárioCaroneiroPreenchido())
            {
                MessageBox.Show("Erro ao cadastrar caroneiro!");
                return;
            }

            String command;
            String RG, veículo, placa, caronas;

            RG = tbUsuárioRG.Text;
            veículo = tbVeículo.Text;
            placa = tbPlaca.Text;
            caronas = nudCaronas.Value.ToString();

            command = "INSERT INTO CARONEIRO (RG, TIPO_VEICULO, PLACA, MAX_CARONAS) VALUES (";
            command += "'" + RG + "', ";
            command += "'" + veículo + "', ";
            command += "'" + placa + "', ";
            command += caronas + ")";

            SqlConnection sqlConnection = new SqlConnection(LoginADM.dbConString);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Caroneiro cadastrado com sucesso!");
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
