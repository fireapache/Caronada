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
        public LoginADM()
        {
            InitializeComponent();
        }

        public static string dbConString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Caronada.mdf;Integrated Security=True;Connect Timeout=30";

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (testarADM())
            {
                Opções op = new Opções();
                this.Hide();
                op.Show();
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
            String dbID, dbSW;

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
            sqlComm = new SqlCommand("SELECT * FROM ADMINISTRADOR", sqlCon);

            sqlCon.Open();
            dataReader = sqlComm.ExecuteReader();

            while (dataReader.Read())
            {
                dbID = dataReader.GetString(0);

                if (dbID == id)
                {
                    dbSW = dataReader.GetString(1);

                    if (dbSW == sw)
                    {
                        loginMatch = true;
                        break;
                    }
                }
            }

            sqlCon.Close();

            return loginMatch;
        }
    }
}
