using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Bingo_ProjetoFinal
{
    public partial class FrmSaldo : Form
    {
        ClassMusica classeMusica = new ClassMusica();
        public FrmSaldo()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();
            FrmMain.saldoAdicionado = int.Parse(txtSaldo.Text);
            MessageBox.Show("Depósito feito! Aperte o botão ao lado para atualizar o valor");
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            classeMusica.musicaSair();
            this.Close();
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = !string.IsNullOrWhiteSpace(txtSaldo.Text);
        }
    }
}
