﻿using System;
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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void rdCaroneiro_CheckedChanged(object sender, EventArgs e)
        {
            tbTipoCarro.Show();
            textBox3.Show();
            nudCaronas.Show();

            nudPeso.Hide();
            nudAltura.Hide();

            lbTipoCarro.Show();
            lbPlaca.Show();
            lbCaronas.Show();

            lbPeso.Hide();
            lbAltura.Hide();
        }

        private void rdCarona_CheckedChanged(object sender, EventArgs e)
        {
            tbTipoCarro.Hide();
            textBox3.Hide();
            nudCaronas.Hide();

            nudPeso.Show();
            nudAltura.Show();

            lbPeso.Show();
            lbAltura.Show();

            lbTipoCarro.Hide();
            lbPlaca.Hide();
            lbCaronas.Hide();
        }

        private void rdUsuário_CheckedChanged(object sender, EventArgs e)
        {
            tbTipoCarro.Hide();
            textBox3.Hide();
            nudCaronas.Hide();
            nudPeso.Hide();
            nudAltura.Hide();

            lbTipoCarro.Hide();
            lbPlaca.Hide();
            lbCaronas.Hide();
            lbPeso.Hide();
            lbAltura.Hide();
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
            MessageBox.Show(this, "Ainda não foi implementado!");
        }
    }
}
