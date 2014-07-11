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
    public partial class Opções : Form
    {
        public Opções()
        {
            InitializeComponent();
        }

        private void Opções_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            LoginADM.showCadastro();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            LoginADM.showInserir();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            LoginADM.showProcurar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LoginADM.showExcluir();
        }

        private void llbADM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginADM.showLoginADM();
        }

        public void setADM(String ADM)
        {
            llbADM.Text = ADM;
        }
    }
}
