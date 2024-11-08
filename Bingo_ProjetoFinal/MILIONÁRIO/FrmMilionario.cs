using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo_ProjetoFinal.MILIONÁRIO
{
    public partial class FrmMilionario : Form
    {
        public static bool flagMilionário = false;
        ClassMusica classeMusica = new ClassMusica();
        public FrmMilionario()
        {
            InitializeComponent();
            
            classeMusica.musicaIntro();
            lblSaldo.Text = (FrmMain.saldo + "€");
            if (FrmMain.saldo >= 1)
            {
                btnJogar.Enabled = true;
            }
            else
            {
                btnJogar.Enabled = false;
            }


        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmValorApostaMilionario fam = new FrmValorApostaMilionario();
            fam.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            classeMusica.musicaSair();
            this.Close();
            FrmMenuSair j = new FrmMenuSair();
            j.Show();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            btnAdicionar.Visible = false;
            btnAtualizarSaldo.Visible = true;
            FrmSacarDinheiro fsa = new FrmSacarDinheiro();
            fsa.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnAdicionar.Visible = false;
            btnAtualizarSaldo.Visible = true;
            FrmSaldo fs = new FrmSaldo();
            fs.ShowDialog();
        }

        private void btnAtualizarSaldo_Click(object sender, EventArgs e)
        {
            btnAtualizarSaldo.Visible = false;
            FrmMain.saldo += FrmMain.saldoAdicionado;
            lblSaldo.Text = (FrmMain.saldo + "€");
            btnAdicionar.Visible = true;
            FrmMain.saldoAdicionado = 0;
            if (FrmMain.saldo >= 1)
            {
                btnJogar.Enabled = true;
            }
        }
    }
}
