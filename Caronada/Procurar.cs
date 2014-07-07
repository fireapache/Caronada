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
        public Procurar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipo == 1) Procura.procuraUser(RG.Text);
            if (tipo == 2) Procura.procuraCaroneiro(RG.Text);
            if (tipo == 3) Procura.procuraCarona(RG.Text);
            if (tipo == 4) Procura.procuraComentario(RG.Text);
            if (tipo == 5) Procura.procuraGrupo(RG.Text);
         

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
            if(checkList.Checked)
            {
                RG.Enabled = false;
            }
            else
            {
                RG.Enabled = true;
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
