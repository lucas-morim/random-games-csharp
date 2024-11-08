using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo_ProjetoFinal
{
    public partial class FrmSacarDinheiro : Form
    {
        ClassMusica classeMusica = new ClassMusica();
        int sacar = 0;
        public FrmSacarDinheiro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            classeMusica.musicaSair();
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();
            sacar = int.Parse(txtValor.Text);
            if (FrmMain.saldo >= sacar)
            {
                FrmMain.saldo -= sacar;
                MessageBox.Show("Saque feito! Aperte o botão ao lado para atualizar o valor");
                this.Close();
            }
            else
            {
                MessageBox.Show("Saque cancelado! Valor maior que o saldo atual");
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = !string.IsNullOrWhiteSpace(txtValor.Text);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
