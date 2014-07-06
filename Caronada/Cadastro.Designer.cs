namespace Caronada
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.tbRG = new System.Windows.Forms.TextBox();
            this.rdCaroneiro = new System.Windows.Forms.RadioButton();
            this.Carona = new System.Windows.Forms.RadioButton();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.tbTipoCarro = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.rdUsuário = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbRG = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbTipoCarro = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbCaronas = new System.Windows.Forms.Label();
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.nudCaronas = new System.Windows.Forms.NumericUpDown();
            this.lbHoraIda = new System.Windows.Forms.Label();
            this.timeHoraIda = new System.Windows.Forms.DateTimePicker();
            this.lbHoraVolta = new System.Windows.Forms.Label();
            this.timeHoraVolta = new System.Windows.Forms.DateTimePicker();
            this.lbRegião = new System.Windows.Forms.Label();
            this.tbRegião = new System.Windows.Forms.TextBox();
            this.lbContato = new System.Windows.Forms.Label();
            this.tbContato = new System.Windows.Forms.TextBox();
            this.lbUsuárioRG = new System.Windows.Forms.Label();
            this.tbUsuárioRG = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaronas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRG
            // 
            this.tbRG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRG.Location = new System.Drawing.Point(76, 12);
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(200, 20);
            this.tbRG.TabIndex = 0;
            // 
            // rdCaroneiro
            // 
            this.rdCaroneiro.AutoSize = true;
            this.rdCaroneiro.Location = new System.Drawing.Point(76, 199);
            this.rdCaroneiro.Name = "rdCaroneiro";
            this.rdCaroneiro.Size = new System.Drawing.Size(70, 17);
            this.rdCaroneiro.TabIndex = 1;
            this.rdCaroneiro.TabStop = true;
            this.rdCaroneiro.Text = "Caroneiro";
            this.rdCaroneiro.UseVisualStyleBackColor = true;
            this.rdCaroneiro.CheckedChanged += new System.EventHandler(this.rdCaroneiro_CheckedChanged);
            // 
            // Carona
            // 
            this.Carona.AutoSize = true;
            this.Carona.Location = new System.Drawing.Point(152, 199);
            this.Carona.Name = "Carona";
            this.Carona.Size = new System.Drawing.Size(59, 17);
            this.Carona.TabIndex = 2;
            this.Carona.TabStop = true;
            this.Carona.Text = "Carona";
            this.Carona.UseVisualStyleBackColor = true;
            this.Carona.CheckedChanged += new System.EventHandler(this.rdCarona_CheckedChanged);
            // 
            // tbNome
            // 
            this.tbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNome.Location = new System.Drawing.Point(76, 38);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(200, 20);
            this.tbNome.TabIndex = 3;
            // 
            // dateNascimento
            // 
            this.dateNascimento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNascimento.Location = new System.Drawing.Point(76, 64);
            this.dateNascimento.MinDate = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(200, 20);
            this.dateNascimento.TabIndex = 4;
            this.dateNascimento.Value = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            // 
            // tbTipoCarro
            // 
            this.tbTipoCarro.Location = new System.Drawing.Point(76, 251);
            this.tbTipoCarro.Name = "tbTipoCarro";
            this.tbTipoCarro.Size = new System.Drawing.Size(200, 20);
            this.tbTipoCarro.TabIndex = 7;
            this.tbTipoCarro.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Visible = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(7, 354);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 50);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "  Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(114, 354);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 50);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar      ";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // rdUsuário
            // 
            this.rdUsuário.AutoSize = true;
            this.rdUsuário.Checked = true;
            this.rdUsuário.Location = new System.Drawing.Point(217, 199);
            this.rdUsuário.Name = "rdUsuário";
            this.rdUsuário.Size = new System.Drawing.Size(61, 17);
            this.rdUsuário.TabIndex = 12;
            this.rdUsuário.TabStop = true;
            this.rdUsuário.Text = "Usuario";
            this.rdUsuário.UseVisualStyleBackColor = true;
            this.rdUsuário.CheckedChanged += new System.EventHandler(this.rdUsuário_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(222, 354);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 50);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair         ";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(4, 15);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(26, 13);
            this.lbRG.TabIndex = 17;
            this.lbRG.Text = "RG:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(4, 41);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 18;
            this.lbNome.Text = "Nome:";
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Location = new System.Drawing.Point(4, 70);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(66, 13);
            this.lbNascimento.TabIndex = 19;
            this.lbNascimento.Text = "Nascimento:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(4, 203);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(31, 13);
            this.lbTipo.TabIndex = 20;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbTipoCarro
            // 
            this.lbTipoCarro.AutoSize = true;
            this.lbTipoCarro.Location = new System.Drawing.Point(4, 254);
            this.lbTipoCarro.Name = "lbTipoCarro";
            this.lbTipoCarro.Size = new System.Drawing.Size(59, 13);
            this.lbTipoCarro.TabIndex = 21;
            this.lbTipoCarro.Text = "Tipo Carro:";
            this.lbTipoCarro.Visible = false;
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(4, 280);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(37, 13);
            this.lbPlaca.TabIndex = 22;
            this.lbPlaca.Text = "Placa:";
            this.lbPlaca.Visible = false;
            // 
            // lbCaronas
            // 
            this.lbCaronas.AutoSize = true;
            this.lbCaronas.Location = new System.Drawing.Point(4, 306);
            this.lbCaronas.Name = "lbCaronas";
            this.lbCaronas.Size = new System.Drawing.Size(49, 13);
            this.lbCaronas.TabIndex = 23;
            this.lbCaronas.Text = "Caronas:";
            this.lbCaronas.Visible = false;
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(4, 254);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(34, 13);
            this.lbPeso.TabIndex = 24;
            this.lbPeso.Text = "Peso:";
            this.lbPeso.Visible = false;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(4, 280);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(37, 13);
            this.lbAltura.TabIndex = 25;
            this.lbAltura.Text = "Altura:";
            this.lbAltura.Visible = false;
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(76, 252);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(70, 20);
            this.nudPeso.TabIndex = 26;
            this.nudPeso.Visible = false;
            // 
            // nudAltura
            // 
            this.nudAltura.Location = new System.Drawing.Point(76, 278);
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(70, 20);
            this.nudAltura.TabIndex = 27;
            this.nudAltura.Visible = false;
            // 
            // nudCaronas
            // 
            this.nudCaronas.Location = new System.Drawing.Point(76, 304);
            this.nudCaronas.Name = "nudCaronas";
            this.nudCaronas.Size = new System.Drawing.Size(70, 20);
            this.nudCaronas.TabIndex = 28;
            this.nudCaronas.Visible = false;
            // 
            // lbHoraIda
            // 
            this.lbHoraIda.AutoSize = true;
            this.lbHoraIda.Location = new System.Drawing.Point(4, 96);
            this.lbHoraIda.Name = "lbHoraIda";
            this.lbHoraIda.Size = new System.Drawing.Size(51, 13);
            this.lbHoraIda.TabIndex = 29;
            this.lbHoraIda.Text = "Hora Ida:";
            // 
            // timeHoraIda
            // 
            this.timeHoraIda.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHoraIda.Location = new System.Drawing.Point(76, 90);
            this.timeHoraIda.Name = "timeHoraIda";
            this.timeHoraIda.Size = new System.Drawing.Size(200, 20);
            this.timeHoraIda.TabIndex = 30;
            // 
            // lbHoraVolta
            // 
            this.lbHoraVolta.AutoSize = true;
            this.lbHoraVolta.Location = new System.Drawing.Point(4, 122);
            this.lbHoraVolta.Name = "lbHoraVolta";
            this.lbHoraVolta.Size = new System.Drawing.Size(60, 13);
            this.lbHoraVolta.TabIndex = 31;
            this.lbHoraVolta.Text = "Hora Volta:";
            // 
            // timeHoraVolta
            // 
            this.timeHoraVolta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHoraVolta.Location = new System.Drawing.Point(76, 116);
            this.timeHoraVolta.Name = "timeHoraVolta";
            this.timeHoraVolta.Size = new System.Drawing.Size(200, 20);
            this.timeHoraVolta.TabIndex = 32;
            // 
            // lbRegião
            // 
            this.lbRegião.AutoSize = true;
            this.lbRegião.Location = new System.Drawing.Point(4, 145);
            this.lbRegião.Name = "lbRegião";
            this.lbRegião.Size = new System.Drawing.Size(44, 13);
            this.lbRegião.TabIndex = 33;
            this.lbRegião.Text = "Região:";
            // 
            // tbRegião
            // 
            this.tbRegião.Location = new System.Drawing.Point(76, 142);
            this.tbRegião.Name = "tbRegião";
            this.tbRegião.Size = new System.Drawing.Size(200, 20);
            this.tbRegião.TabIndex = 34;
            // 
            // lbContato
            // 
            this.lbContato.AutoSize = true;
            this.lbContato.Location = new System.Drawing.Point(4, 171);
            this.lbContato.Name = "lbContato";
            this.lbContato.Size = new System.Drawing.Size(47, 13);
            this.lbContato.TabIndex = 35;
            this.lbContato.Text = "Contato:";
            // 
            // tbContato
            // 
            this.tbContato.Location = new System.Drawing.Point(76, 168);
            this.tbContato.Name = "tbContato";
            this.tbContato.Size = new System.Drawing.Size(200, 20);
            this.tbContato.TabIndex = 36;
            // 
            // lbUsuárioRG
            // 
            this.lbUsuárioRG.AutoSize = true;
            this.lbUsuárioRG.Location = new System.Drawing.Point(4, 230);
            this.lbUsuárioRG.Name = "lbUsuárioRG";
            this.lbUsuárioRG.Size = new System.Drawing.Size(65, 13);
            this.lbUsuárioRG.TabIndex = 37;
            this.lbUsuárioRG.Text = "Usuário RG:";
            this.lbUsuárioRG.Visible = false;
            // 
            // tbUsuárioRG
            // 
            this.tbUsuárioRG.Location = new System.Drawing.Point(76, 225);
            this.tbUsuárioRG.Name = "tbUsuárioRG";
            this.tbUsuárioRG.Size = new System.Drawing.Size(200, 20);
            this.tbUsuárioRG.TabIndex = 38;
            this.tbUsuárioRG.Visible = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 413);
            this.Controls.Add(this.tbUsuárioRG);
            this.Controls.Add(this.lbUsuárioRG);
            this.Controls.Add(this.tbContato);
            this.Controls.Add(this.lbContato);
            this.Controls.Add(this.tbRegião);
            this.Controls.Add(this.lbRegião);
            this.Controls.Add(this.timeHoraVolta);
            this.Controls.Add(this.lbHoraVolta);
            this.Controls.Add(this.timeHoraIda);
            this.Controls.Add(this.lbHoraIda);
            this.Controls.Add(this.nudCaronas);
            this.Controls.Add(this.nudAltura);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.lbCaronas);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lbTipoCarro);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbNascimento);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbRG);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.rdUsuário);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbTipoCarro);
            this.Controls.Add(this.dateNascimento);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.Carona);
            this.Controls.Add(this.rdCaroneiro);
            this.Controls.Add(this.tbRG);
            this.Name = "Cadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cadastro_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaronas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdCaroneiro;
        private System.Windows.Forms.RadioButton Carona;
        private System.Windows.Forms.TextBox tbRG;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        public System.Windows.Forms.TextBox tbTipoCarro;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton rdUsuário;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbTipoCarro;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbCaronas;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.NumericUpDown nudCaronas;
        private System.Windows.Forms.Label lbHoraIda;
        private System.Windows.Forms.DateTimePicker timeHoraIda;
        private System.Windows.Forms.Label lbHoraVolta;
        private System.Windows.Forms.DateTimePicker timeHoraVolta;
        private System.Windows.Forms.Label lbRegião;
        private System.Windows.Forms.TextBox tbRegião;
        private System.Windows.Forms.Label lbContato;
        private System.Windows.Forms.TextBox tbContato;
        private System.Windows.Forms.Label lbUsuárioRG;
        private System.Windows.Forms.TextBox tbUsuárioRG;
    }
}