namespace Bingo_ProjetoFinal.MILIONÁRIO
{
    partial class FrmMilionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMilionario));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnSaque = new ePOSOne.btnProduct.Button_WOC();
            this.btnAdicionar = new ePOSOne.btnProduct.Button_WOC();
            this.btnAtualizarSaldo = new ePOSOne.btnProduct.Button_WOC();
            this.btnSaldo = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(381, 326);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(119, 31);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJogar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnJogar.FlatAppearance.BorderSize = 0;
            this.btnJogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnJogar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJogar.Location = new System.Drawing.Point(23, 326);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(119, 31);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.White;
            this.lblSaldo.Font = new System.Drawing.Font("Baskerville Old Face", 15F);
            this.lblSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldo.Location = new System.Drawing.Point(357, 15);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(54, 23);
            this.lblSaldo.TabIndex = 136;
            this.lblSaldo.Text = "Saldo";
            // 
            // btnSaque
            // 
            this.btnSaque.BackColor = System.Drawing.Color.White;
            this.btnSaque.BorderColor = System.Drawing.Color.Black;
            this.btnSaque.ButtonColor = System.Drawing.Color.White;
            this.btnSaque.FlatAppearance.BorderSize = 0;
            this.btnSaque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSaque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaque.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.Location = new System.Drawing.Point(421, 12);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSaque.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.btnSaque.OnHoverTextColor = System.Drawing.SystemColors.HighlightText;
            this.btnSaque.Size = new System.Drawing.Size(32, 29);
            this.btnSaque.TabIndex = 139;
            this.btnSaque.Text = "$";
            this.btnSaque.TextColor = System.Drawing.Color.Black;
            this.btnSaque.UseVisualStyleBackColor = false;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.BorderColor = System.Drawing.Color.Black;
            this.btnAdicionar.ButtonColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.Location = new System.Drawing.Point(459, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnAdicionar.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.btnAdicionar.OnHoverTextColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdicionar.Size = new System.Drawing.Size(32, 29);
            this.btnAdicionar.TabIndex = 138;
            this.btnAdicionar.Text = "➕";
            this.btnAdicionar.TextColor = System.Drawing.Color.Black;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAtualizarSaldo
            // 
            this.btnAtualizarSaldo.BackColor = System.Drawing.Color.White;
            this.btnAtualizarSaldo.BorderColor = System.Drawing.Color.Black;
            this.btnAtualizarSaldo.ButtonColor = System.Drawing.Color.White;
            this.btnAtualizarSaldo.FlatAppearance.BorderSize = 0;
            this.btnAtualizarSaldo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAtualizarSaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAtualizarSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarSaldo.Location = new System.Drawing.Point(459, 12);
            this.btnAtualizarSaldo.Name = "btnAtualizarSaldo";
            this.btnAtualizarSaldo.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnAtualizarSaldo.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.btnAtualizarSaldo.OnHoverTextColor = System.Drawing.SystemColors.HighlightText;
            this.btnAtualizarSaldo.Size = new System.Drawing.Size(32, 29);
            this.btnAtualizarSaldo.TabIndex = 140;
            this.btnAtualizarSaldo.Text = "⟳";
            this.btnAtualizarSaldo.TextColor = System.Drawing.Color.Black;
            this.btnAtualizarSaldo.UseVisualStyleBackColor = false;
            this.btnAtualizarSaldo.Click += new System.EventHandler(this.btnAtualizarSaldo_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.Color.Transparent;
            this.btnSaldo.BorderColor = System.Drawing.Color.Black;
            this.btnSaldo.ButtonColor = System.Drawing.Color.White;
            this.btnSaldo.FlatAppearance.BorderSize = 0;
            this.btnSaldo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaldo.Location = new System.Drawing.Point(347, 6);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaldo.OnHoverButtonColor = System.Drawing.Color.White;
            this.btnSaldo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaldo.Size = new System.Drawing.Size(158, 41);
            this.btnSaldo.TabIndex = 137;
            this.btnSaldo.TextColor = System.Drawing.Color.White;
            this.btnSaldo.UseVisualStyleBackColor = false;
            // 
            // FrmMilionário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnAtualizarSaldo);
            this.Controls.Add(this.btnSaldo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMilionário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnJogar;
        private ePOSOne.btnProduct.Button_WOC btnSaque;
        private ePOSOne.btnProduct.Button_WOC btnAdicionar;
        private System.Windows.Forms.Label lblSaldo;
        private ePOSOne.btnProduct.Button_WOC btnSaldo;
        private ePOSOne.btnProduct.Button_WOC btnAtualizarSaldo;
    }
}