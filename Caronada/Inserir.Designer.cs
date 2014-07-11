namespace Caronada
{
    partial class Inserir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inserir));
            this.tbRG = new System.Windows.Forms.TextBox();
            this.tbComentário = new System.Windows.Forms.TextBox();
            this.rbComentario = new System.Windows.Forms.RadioButton();
            this.rbGrupo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbRG = new System.Windows.Forms.Label();
            this.lbComentário = new System.Windows.Forms.Label();
            this.lbRegiãoID = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.nudRegiãoID = new System.Windows.Forms.NumericUpDown();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbReferência = new System.Windows.Forms.Label();
            this.tbReferência = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegiãoID)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRG
            // 
            this.tbRG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRG.Location = new System.Drawing.Point(101, 38);
            this.tbRG.MaxLength = 10;
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(200, 20);
            this.tbRG.TabIndex = 2;
            this.tbRG.Visible = false;
            // 
            // tbComentário
            // 
            this.tbComentário.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbComentário.Location = new System.Drawing.Point(101, 64);
            this.tbComentário.MaxLength = 256;
            this.tbComentário.Multiline = true;
            this.tbComentário.Name = "tbComentário";
            this.tbComentário.Size = new System.Drawing.Size(200, 87);
            this.tbComentário.TabIndex = 4;
            this.tbComentário.Visible = false;
            // 
            // rbComentario
            // 
            this.rbComentario.AutoSize = true;
            this.rbComentario.Location = new System.Drawing.Point(101, 12);
            this.rbComentario.Name = "rbComentario";
            this.rbComentario.Size = new System.Drawing.Size(78, 17);
            this.rbComentario.TabIndex = 7;
            this.rbComentario.TabStop = true;
            this.rbComentario.Text = "Comentario";
            this.rbComentario.UseVisualStyleBackColor = true;
            this.rbComentario.CheckedChanged += new System.EventHandler(this.Comentario_CheckedChanged);
            // 
            // rbGrupo
            // 
            this.rbGrupo.AutoSize = true;
            this.rbGrupo.Location = new System.Drawing.Point(199, 12);
            this.rbGrupo.Name = "rbGrupo";
            this.rbGrupo.Size = new System.Drawing.Size(59, 17);
            this.rbGrupo.TabIndex = 8;
            this.rbGrupo.TabStop = true;
            this.rbGrupo.Text = "Região";
            this.rbGrupo.UseVisualStyleBackColor = true;
            this.rbGrupo.CheckedChanged += new System.EventHandler(this.Região_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(120, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "Voltar      ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(228, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 44);
            this.button3.TabIndex = 21;
            this.button3.Text = "Sair        ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tipo:";
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(12, 41);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(26, 13);
            this.lbRG.TabIndex = 34;
            this.lbRG.Text = "RG:";
            this.lbRG.Visible = false;
            // 
            // lbComentário
            // 
            this.lbComentário.AutoSize = true;
            this.lbComentário.Location = new System.Drawing.Point(12, 67);
            this.lbComentário.Name = "lbComentário";
            this.lbComentário.Size = new System.Drawing.Size(63, 13);
            this.lbComentário.TabIndex = 36;
            this.lbComentário.Text = "Comentario:";
            this.lbComentário.Visible = false;
            // 
            // lbRegiãoID
            // 
            this.lbRegiãoID.AutoSize = true;
            this.lbRegiãoID.Location = new System.Drawing.Point(15, 41);
            this.lbRegiãoID.Name = "lbRegiãoID";
            this.lbRegiãoID.Size = new System.Drawing.Size(21, 13);
            this.lbRegiãoID.TabIndex = 37;
            this.lbRegiãoID.Text = "ID:";
            this.lbRegiãoID.Visible = false;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(101, 64);
            this.tbBairro.MaxLength = 32;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(200, 20);
            this.tbBairro.TabIndex = 39;
            this.tbBairro.Visible = false;
            // 
            // nudRegiãoID
            // 
            this.nudRegiãoID.Location = new System.Drawing.Point(101, 38);
            this.nudRegiãoID.Name = "nudRegiãoID";
            this.nudRegiãoID.Size = new System.Drawing.Size(63, 20);
            this.nudRegiãoID.TabIndex = 40;
            this.nudRegiãoID.Visible = false;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(12, 67);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(37, 13);
            this.lbBairro.TabIndex = 41;
            this.lbBairro.Text = "Bairro:";
            this.lbBairro.Visible = false;
            // 
            // lbReferência
            // 
            this.lbReferência.AutoSize = true;
            this.lbReferência.Location = new System.Drawing.Point(15, 96);
            this.lbReferência.Name = "lbReferência";
            this.lbReferência.Size = new System.Drawing.Size(62, 13);
            this.lbReferência.TabIndex = 42;
            this.lbReferência.Text = "Referência:";
            this.lbReferência.Visible = false;
            // 
            // tbReferência
            // 
            this.tbReferência.Location = new System.Drawing.Point(101, 96);
            this.tbReferência.MaxLength = 64;
            this.tbReferência.Name = "tbReferência";
            this.tbReferência.Size = new System.Drawing.Size(200, 20);
            this.tbReferência.TabIndex = 43;
            this.tbReferência.Visible = false;
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 218);
            this.Controls.Add(this.tbReferência);
            this.Controls.Add(this.lbReferência);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.nudRegiãoID);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.lbRegiãoID);
            this.Controls.Add(this.lbComentário);
            this.Controls.Add(this.lbRG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbGrupo);
            this.Controls.Add(this.rbComentario);
            this.Controls.Add(this.tbComentário);
            this.Controls.Add(this.tbRG);
            this.Name = "Inserir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inserir_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudRegiãoID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRG;
        private System.Windows.Forms.TextBox tbComentário;
        private System.Windows.Forms.RadioButton rbComentario;
        private System.Windows.Forms.RadioButton rbGrupo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.Label lbComentário;
        private System.Windows.Forms.Label lbRegiãoID;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.NumericUpDown nudRegiãoID;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbReferência;
        private System.Windows.Forms.TextBox tbReferência;
    }
}