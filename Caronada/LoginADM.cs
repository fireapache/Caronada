using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Caronada
{
    public partial class LoginADM : Form
    {
        private static Opções opções;
        private static Procurar procurar;
        private static Procura procura;
        private static Inserir inserir;
        private static Excluir excluir;
        private static Cadastro cadastro;

        public LoginADM()
        {
            InitializeComponent();
            initializeForms();
            hideForms();
        }

        public static string dbConString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Caronada.mdf;Integrated Security=True;Connect Timeout=30";

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (testarADM())
            {
                showOpções();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERRO DE LOGIN!");
            }
        }

        private bool testarADM()
        {
            SqlConnection sqlCon;
            SqlCommand sqlComm;
            SqlDataReader dataReader;
            String id, sw;
            byte[] hash;
            MD5 hasher;
            bool loginMatch = false;
            String dbSW;

            id = tbID.Text;
            sw = tbSW.Text;
            hasher = MD5.Create();
            hash = Encoding.UTF8.GetBytes(sw);
            hash = hasher.ComputeHash(hash);

            sw = "";

            foreach (byte b in hash)
            {
                sw = sw + b.ToString("x2");
            }

            sqlCon = new SqlConnection(dbConString);
            sqlComm = new SqlCommand("SELECT SW FROM ADMINISTRADOR WHERE ID = '" + id + "'", sqlCon);

            sqlCon.Open();
            dataReader = sqlComm.ExecuteReader();

            if (dataReader.Read())
            {
                dbSW = dataReader.GetString(0);

                if (dbSW == sw)
                {
                    loginMatch = true;
                }
            }

            sqlCon.Close();

            return loginMatch;
        }

        private static void initializeForms()
        {
            opções = new Opções();
            procurar = new Procurar();
            procura = new Procura();
            inserir = new Inserir();
            excluir = new Excluir();
            cadastro = new Cadastro();
        }

        private static void hideForms()
        {
            opções.Hide();
            procurar.Hide();
            procura.Hide();
            inserir.Hide();
            excluir.Hide();
            cadastro.Hide();
        }

        public static void showOpções()
        {
            hideForms();
            opções.Show();
        }

        public static void showProcurar()
        {
            hideForms();
            procurar.Show();
        }

        public static void showProcura()
        {
            hideForms();
            procura.Show();
        }

        public static void showInserir()
        {
            hideForms();
            inserir.Show();
        }

        public static void showExcluir()
        {
            hideForms();
            excluir.Show();
        }

        public static void showCadastro()
        {
            hideForms();
            cadastro.Show();
        }
    }
}
