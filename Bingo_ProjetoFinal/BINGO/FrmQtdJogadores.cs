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
    public partial class FrmQtdJogadores : Form
    {
        ClassMusica classeMusica = new ClassMusica();
        int contador = 0;
        public FrmQtdJogadores()
        {
            InitializeComponent();
        }

        private void btn2Jogadores_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();
            this.Close();
            contador = 2;
            FrmNomeJogador fnj = new FrmNomeJogador(contador);
            fnj.Show();
        }

        private void btn3Jogadores_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();
            this.Close();
            contador = 3;
            FrmNomeJogador fnj = new FrmNomeJogador(contador);
            fnj.Show();
        }

        private void btn4Jogadores_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();
            this.Close();
            contador = 4;
            FrmNomeJogador fnj = new FrmNomeJogador(contador);
            fnj.Show();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            classeMusica.musicaSair();
            this.Close();
            FrmMenuJogos ftj = new FrmMenuJogos();
            ftj.Show();
        }
    }
}
