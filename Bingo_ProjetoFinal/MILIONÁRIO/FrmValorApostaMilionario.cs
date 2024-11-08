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
    public partial class FrmValorApostaMilionario : Form
    {
        ClassMusica classeMusica = new ClassMusica();
        public FrmValorApostaMilionario()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();
            if (rbt1.Checked == true)
            {

                if (FrmMain.saldo < 1)
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
                else
                {
                    FrmMain.aposta = 1;
                    MessageBox.Show("Valor apostado selecionado! Boa sorte!");
                    FrmMain.saldo -= FrmMain.aposta;
                    this.Close();
                    FrmJogo fj = new FrmJogo();
                    fj.Show();
                }
            }
            else if (rbt5.Checked == true)
            {
                if (FrmMain.saldo < 5)
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
                else
                {
                    FrmMain.aposta = 5;
                    MessageBox.Show("Valor apostado selecionado! Boa sorte!");
                    FrmMain.saldo -= FrmMain.aposta;
                    this.Close();
                    FrmJogo fj = new FrmJogo();
                    fj.Show();
                }
            }
            else if (rbt10.Checked == true)
            {
                if (FrmMain.saldo < 10)
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
                else
                {
                    FrmMain.aposta = 10;
                    MessageBox.Show("Valor apostado selecionado! Boa sorte!");
                    FrmMain.saldo -= FrmMain.aposta;
                    this.Close();
                    FrmJogo fj = new FrmJogo();
                    fj.Show();
                }
            }
            else if (rbt20.Checked == true)
            {
                if (FrmMain.saldo < 20)
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
                else
                {
                    FrmMain.aposta = 20;
                    MessageBox.Show("Valor apostado selecionado! Boa sorte!");
                    FrmMain.saldo -= FrmMain.aposta;
                    this.Close();
                    FrmJogo fj = new FrmJogo();
                    fj.Show();
                }
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            classeMusica.musicaSair();
            this.Close();
            FrmMilionario fm = new FrmMilionario();
            fm.Show();
        }
    }
}

