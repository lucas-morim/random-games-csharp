using Bingo_ProjetoFinal.MILIONÁRIO;
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
    public partial class FrmMenuJogos : Form
    {
        ClassMusica classeMusica = new ClassMusica();
        public FrmMenuJogos()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();
            this.Close();
            FrmQtdJogadores fj = new FrmQtdJogadores();
            fj.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            classeMusica.musicaSair();
            this.Close();
            FrmMain fm = new FrmMain();
            fm.Show();
        }

        private void btnBingo_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();
            this.Close();
            FrmQtdJogadores fj = new FrmQtdJogadores();
            fj.Show();
        }

        private void btnRoleta_Click(object sender, EventArgs e)
        {
            classeMusica.musicaJogar();
            this.Close();
            FrmRoleta fr = new FrmRoleta(FrmMain.saldo, FrmMain.aposta);
            fr.Show();
        }

        private void btnMilionário_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMilionario m = new FrmMilionario();
            m.Show();
        }
    }
}
