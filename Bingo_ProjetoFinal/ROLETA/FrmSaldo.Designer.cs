namespace Bingo_ProjetoFinal
{
    partial class FrmSaldo
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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnSair = new ePOSOne.btnProduct.Button_WOC();
            this.btnConfirmar = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Baskerville Old Face", 14F);
            this.lblSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldo.Location = new System.Drawing.Point(4, 9);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(122, 22);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Digite o saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Baskerville Old Face", 10F);
            this.txtSaldo.Location = new System.Drawing.Point(8, 34);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(242, 23);
            this.txtSaldo.TabIndex = 1;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BorderColor = System.Drawing.Color.Gray;
            this.btnSair.ButtonColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(132, 75);
            this.btnSair.Name = "btnSair";
            this.btnSair.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnSair.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnSair.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSair.Size = new System.Drawing.Size(118, 28);
            this.btnSair.TabIndex = 123;
            this.btnSair.Text = "SAIR";
            this.btnSair.TextColor = System.Drawing.Color.Black;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BorderColor = System.Drawing.Color.Gray;
            this.btnConfirmar.ButtonColor = System.Drawing.Color.White;
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(8, 75);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnConfirmar.OnHoverButtonColor = System.Drawing.Color.Black;
            this.btnConfirmar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfirmar.Size = new System.Drawing.Size(118, 28);
            this.btnConfirmar.TabIndex = 122;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.TextColor = System.Drawing.Color.Black;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(260, 115);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADICIONAR SALDO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private ePOSOne.btnProduct.Button_WOC btnConfirmar;
        private ePOSOne.btnProduct.Button_WOC btnSair;
    }
}