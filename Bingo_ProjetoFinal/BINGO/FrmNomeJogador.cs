using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo_ProjetoFinal
{
    public partial class FrmNomeJogador : Form
    {
        int contador2 = 0;
        ClassMusica classeMusica = new ClassMusica();
        public FrmNomeJogador(int contador)
        {
            InitializeComponent();
            if (contador == 3)
            {
                lblJogador1.Visible = true;
                txtJogador1.Visible = true;
                lblJogador2.Visible = true;
                txtJogador2.Visible = true;
                lblJogador3.Visible = true;
                txtJogador3.Visible = true;
            }
            else if (contador == 4)
            {
                lblJogador1.Visible = true;
                txtJogador1.Visible = true;
                lblJogador2.Visible = true;
                txtJogador2.Visible = true;
                lblJogador3.Visible = true;
                txtJogador3.Visible = true;
                lblJogador4.Visible = true;
                txtJogador4.Visible = true;
            }
            contador2 = contador;
        }

        private void abrirNomeJogador(int contador,string nome1, string nome2, string nome3, string nome4)
        {
            if (contador == 2)
            {
                this.Close();
                Frm2Jogadores fj2 = new Frm2Jogadores(nome1,nome2);
                fj2.Show();
            }
            else if (contador == 3)
            {
                this.Close();
                Frm3Jogadores fj3 = new Frm3Jogadores(nome1, nome2, nome3);
                fj3.Show();
            }
            else
            {
                this.Close();
                Frm4Jogadores fj4 = new Frm4Jogadores(nome1, nome2, nome3, nome4);
                fj4.Show();
            }
        }

        private void txtJogador1_TextChanged(object sender, EventArgs e)
        {
            classeMusica.musicaTeclado();
        }

        private void txtJogador2_TextChanged(object sender, EventArgs e)
        {
            classeMusica.musicaTeclado();
        }

        private void txtJogador3_TextChanged(object sender, EventArgs e)
        {
            classeMusica.musicaTeclado();
        }

        private void txtJogador4_TextChanged(object sender, EventArgs e)
        {
            classeMusica.musicaTeclado();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            classeMusica.musicaSair();
            this.Close();
            FrmQtdJogadores fj = new FrmQtdJogadores();
            fj.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();
            string nome1 = txtJogador1.Text;
            string nome2 = txtJogador2.Text;
            string nome3 = txtJogador3.Text;
            string nome4 = txtJogador4.Text;
            abrirNomeJogador(contador2, nome1, nome2, nome3, nome4);
        }
    }
}
