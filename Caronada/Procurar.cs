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
    public partial class Procurar : Form
    {
        int tipo = 0;
        int list_todos = 0;
        public Procurar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipo < 4 && list_todos == 0)
            {
                if (RG.Text.Length != 10)
                {
                    MessageBox.Show("RG precisa conter 10 caracteres!!");
                    return;
                }
            }
            else if (tipo == 0)
            {
                MessageBox.Show("Escolha o tipo de usuário!!");
                return;
            }

            if (tipo == 1 && list_todos == 0) LoginADM.procuraUser(RG.Text);
            else if (tipo == 1 && list_todos == 1) LoginADM.procuraUserTodos();
            else if (tipo == 2 && list_todos == 0) LoginADM.procuraCaroneiro(RG.Text);
            else if (tipo == 2 && list_todos == 1) LoginADM.procuraCaroneiroTodos();
            else if (tipo == 3 && list_todos == 0) LoginADM.procuraCarona(RG.Text);
            else if (tipo == 3 && list_todos == 1) LoginADM.procuraCaronaTodos();
            else if (tipo == 4 && list_todos == 0) LoginADM.procuraComentario(nudCR.Value.ToString());
            else if (tipo == 4 && list_todos == 1) LoginADM.procuraComentarioTodos();
            else if (tipo == 5 && list_todos == 0) LoginADM.procuraRegião(nudCR.Value.ToString());
            else if (tipo == 5 && list_todos == 1) LoginADM.procuraRegiãoTodos();

            LoginADM.showProcura();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginADM.showOpções();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            list_todos = 1;
            if(checkList.Checked)
            {
                RG.Enabled = false;
                nudCR.Enabled = false;
            }
            else
            {
                RG.Enabled = true;
                nudCR.Enabled = true;
                list_todos = 0;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 1;
            //usuario
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
            //caroneiro
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 3;
            //carona
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 4;
            //comentario

            if (radioButton5.Checked)
            {
                RG.Enabled = false;
                nudCR.Enabled = true;
            }
            else
            {
                RG.Enabled = true;
                nudCR.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 5;
            //grupo

            if (radioButton3.Checked)
            {
                RG.Enabled = false;
                nudCR.Enabled = true;
            }
            else
            {
                RG.Enabled = true;
                nudCR.Enabled = false;
            }
        }

        private void Procurar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
