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
            if (tipo != 0)
            {
                if (RG.TextLength == 10 || list_todos == 11)
                {
                    if (tipo == 1 && list_todos == 0) Procura.procuraUser(RG.Text);
                    if (tipo == 1 && list_todos == 11) Procura.procuraUserTodos();
                    if (tipo == 2 && list_todos == 0) Procura.procuraCaroneiro(RG.Text);
                    if (tipo == 2 && list_todos == 11) Procura.procuraCaroneiroTodos();
                    if (tipo == 3 && list_todos == 0) Procura.procuraCarona(RG.Text);
                    if (tipo == 3 && list_todos == 11) Procura.procuraCaronaTodos();
                    if (tipo == 4 && list_todos == 0) Procura.procuraComentario(RG.Text);
                    if (tipo == 4 && list_todos == 11) Procura.procuraComentarioTodos();
                    //if (tipo == 5) Procura.procuraGrupo(RG.Text);
                    LoginADM.showProcura();
                }
                else
                {
                    MessageBox.Show("RG precisa conter 10 caracteres!!");
                }
            }
            else
            {
                MessageBox.Show("Escolha o tipo de usuário!!");
            }

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
            list_todos = 11;
            if(checkList.Checked)
            {
                RG.Enabled = false;         
            }
            else
            {
                RG.Enabled = true;
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

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 5;
            //grupo
        }
    }
}
