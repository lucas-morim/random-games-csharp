namespace Bingo_ProjetoFinal
{
    partial class FrmNomeJogador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNomeJogador));
            this.txtJogador1 = new System.Windows.Forms.TextBox();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.txtJogador2 = new System.Windows.Forms.TextBox();
            this.lblJogador3 = new System.Windows.Forms.Label();
            this.txtJogador3 = new System.Windows.Forms.TextBox();
            this.lblJogador4 = new System.Windows.Forms.Label();
            this.txtJogador4 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new ePOSOne.btnProduct.Button_WOC();
            this.btnConfirmar = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJogador1
            // 
            this.txtJogador1.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.txtJogador1.Location = new System.Drawing.Point(55, 222);
            this.txtJogador1.Name = "txtJogador1";
            this.txtJogador1.Size = new System.Drawing.Size(135, 23);
            this.txtJogador1.TabIndex = 6;
            this.txtJogador1.TextChanged += new System.EventHandler(this.txtJogador1_TextChanged);
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador1.ForeColor = System.Drawing.Color.White;
            this.lblJogador1.Location = new System.Drawing.Point(52, 201);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(115, 18);
            this.lblJogador1.TabIndex = 7;
            this.lblJogador1.Text = "Nome jogador 1:";
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador2.ForeColor = System.Drawing.Color.White;
            this.lblJogador2.Location = new System.Drawing.Point(230, 201);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(115, 18);
            this.lblJogador2.TabIndex = 9;
            this.lblJogador2.Text = "Nome jogador 2:";
            // 
            // txtJogador2
            // 
            this.txtJogador2.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.txtJogador2.Location = new System.Drawing.Point(233, 222);
            this.txtJogador2.Name = "txtJogador2";
            this.txtJogador2.Size = new System.Drawing.Size(135, 23);
            this.txtJogador2.TabIndex = 8;
            this.txtJogador2.TextChanged += new System.EventHandler(this.txtJogador2_TextChanged);
            // 
            // lblJogador3
            // 
            this.lblJogador3.AutoSize = true;
            this.lblJogador3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador3.ForeColor = System.Drawing.Color.White;
            this.lblJogador3.Location = new System.Drawing.Point(52, 281);
            this.lblJogador3.Name = "lblJogador3";
            this.lblJogador3.Size = new System.Drawing.Size(115, 18);
            this.lblJogador3.TabIndex = 11;
            this.lblJogador3.Text = "Nome jogador 3:";
            this.lblJogador3.Visible = false;
            // 
            // txtJogador3
            // 
            this.txtJogador3.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.txtJogador3.Location = new System.Drawing.Point(55, 302);
            this.txtJogador3.Name = "txtJogador3";
            this.txtJogador3.Size = new System.Drawing.Size(135, 23);
            this.txtJogador3.TabIndex = 10;
            this.txtJogador3.Visible = false;
            this.txtJogador3.TextChanged += new System.EventHandler(this.txtJogador3_TextChanged);
            // 
            // lblJogador4
            // 
            this.lblJogador4.AutoSize = true;
            this.lblJogador4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador4.ForeColor = System.Drawing.Color.White;
            this.lblJogador4.Location = new System.Drawing.Point(230, 281);
            this.lblJogador4.Name = "lblJogador4";
            this.lblJogador4.Size = new System.Drawing.Size(115, 18);
            this.lblJogador4.TabIndex = 13;
            this.lblJogador4.Text = "Nome jogador 4:";
            this.lblJogador4.Visible = false;
            // 
            // txtJogador4
            // 
            this.txtJogador4.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.txtJogador4.Location = new System.Drawing.Point(233, 302);
            this.txtJogador4.Name = "txtJogador4";
            this.txtJogador4.Size = new System.Drawing.Size(135, 23);
            this.txtJogador4.TabIndex = 12;
            this.txtJogador4.Visible = false;
            this.txtJogador4.TextChanged += new System.EventHandler(this.txtJogador4_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, -82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BorderColor = System.Drawing.Color.Gray;
            this.btnVoltar.ButtonColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(233, 360);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnVoltar.OnHoverButtonColor = System.Drawing.SystemColors.HighlightText;
            this.btnVoltar.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Size = new System.Drawing.Size(135, 55);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BorderColor = System.Drawing.Color.Gray;
            this.btnConfirmar.ButtonColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(55, 360);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnConfirmar.OnHoverButtonColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirmar.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmar.Size = new System.Drawing.Size(135, 55);
            this.btnConfirmar.TabIndex = 25;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmNomeJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblJogador1);
            this.Controls.Add(this.txtJogador1);
            this.Controls.Add(this.lblJogador4);
            this.Controls.Add(this.txtJogador4);
            this.Controls.Add(this.lblJogador3);
            this.Controls.Add(this.txtJogador3);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.txtJogador2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNomeJogador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOMES JOGADORES";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtJogador1;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.TextBox txtJogador2;
        private System.Windows.Forms.Label lblJogador3;
        private System.Windows.Forms.TextBox txtJogador3;
        private System.Windows.Forms.Label lblJogador4;
        private System.Windows.Forms.TextBox txtJogador4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC btnVoltar;
        private ePOSOne.btnProduct.Button_WOC btnConfirmar;
    }
}